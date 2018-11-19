using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Maze
{

    public partial class MainForm : Form
    {
        //变量区
        #region 
        /// <summary>
        /// 行数，默认为8
        /// </summary>
        int rows = 8;
        /// <summary>
        /// 列数，默认为8
        /// </summary>
        int cols = 8;
        /// <summary>
        /// 地图左边缘位置
        /// </summary>
        const int left = 30;
        /// <summary>
        /// 地图上边缘位置
        /// </summary>
        const int top = 70;
        /// <summary>
        /// 地图原始高度
        /// </summary>
        const int height = 350;
        /// <summary>
        /// 地图原始宽度
        /// </summary>
        const int width = 350;
        /// <summary>
        /// 地图真实高度
        /// </summary>
        int height_real = 0;
        /// <summary>
        /// 地图真实宽度
        /// </summary>
        int width_real = 0;
        /// <summary>
        /// 最大行数+1
        /// </summary>
        const int max_rows = 31;
        /// <summary>
        /// 最大列数+1
        /// </summary>
        const int max_cols = 31;
        /// <summary>
        /// 绘制直线笔
        /// </summary>
        Pen line_pen = new Pen(Color.White);
        /// <summary>
        /// 地图矩阵 [row, col] 0:道路 1:墙壁 2:已走路径
        /// </summary>
        int [,] map;
        /// <summary>
        /// 设置模式 
        /// 0:无状态
        /// 1:设置墙壁
        /// 2:设置道路
        /// 3:设置起点
        /// 4:设置终点
        /// </summary>
        int mode = 0;
        /// <summary>
        /// 兔子位置
        /// </summary>
        Position Start = new Position();
        /// <summary>
        /// 萝卜位置
        /// </summary>
        Position End = new Position();
        /// <summary>
        /// 已找到的结果
        /// </summary>
        Node result;
        /// <summary>
        /// 移动方向 0:右 1:下 2:左 3:上
        /// </summary>
        int[] dir_x = new int[4] { 0, 1, 0, -1 };
        int[] dir_y = new int[4] { 1, 0, -1, 0 };
        /// <summary>
        /// 显示速度
        /// </summary>
        int speed = 50;
        /// <summary>
        /// 检测鼠标是否按下
        /// </summary>
        bool isDown = false;
        bool isMove = false;
        /// <summary>
        /// 面板相对于屏幕的坐标
        /// </summary>
        int x_position = 0;
        int y_position = 0;
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            PaintEventArgs pe = new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle);
            DrawGrid(pe);
            result = null;
            map = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    map[i, j] = 0;
        }

        /// <summary>
        /// 绘制网格
        /// </summary>
        /// <param name="e"></param>
        public void DrawGrid(PaintEventArgs e)
        {
            // 直线的起点终点
            Point start = new Point();
            Point end = new Point();
            Rectangle Rec = new Rectangle(left, top, width, height);
            e.Graphics.FillRectangle(new SolidBrush(Color.SteelBlue), Rec);
            // 绘制竖线
            // 每列宽度
            int len_col = width / cols;
            // 每行高度
            int len_row = height / rows;
            height_real = len_row * rows;
            width_real = cols * len_col;

            start.Y = top;
            end.Y = top + height_real;
            for (int col = 0; col <= cols; col++)
            {
                start.X = left + col * len_col;
                end.X = left + col * len_col;
                e.Graphics.DrawLine(line_pen, start, end);
            }

            // 绘制横线
            start.X = left;
            end.X = left + width_real;

            for(int row = 0; row <= rows; row++)
            {
                start.Y = top + row * len_row;
                end.Y = top + row * len_row;
                e.Graphics.DrawLine(line_pen, start, end);
            }

            //初始化兔子、萝卜
            Start.x = -1;
            Start.y = -1;
            End.x = -1;
            End.y = -1;
            label_start_position.Text = "还未放置兔子！";
            label_end_position.Text = "还未放置萝卜！";

            //初始化按键及模式
            mode = 0;
            button_wall.BackColor = Color.SteelBlue;
            button_road.BackColor = Color.SteelBlue;
            button_start.BackColor = Color.SteelBlue;
            button_end.BackColor = Color.SteelBlue;
            button_result.BackColor = Color.SteelBlue;

            //初始化结果计算
            result = null;
            label_time_display.Text = "尚未搜索";
        }

        /// <summary>
        /// 行输入 点击即全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_rows_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Tag = 1;
            txt.SelectAll();
        }

        /// <summary>
        /// 列输入 点击即全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_cols_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Tag = 1;
            txt.SelectAll();
        }

        /// <summary>
        /// 确认行列输入并绘制网格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_shape_Click(object sender, EventArgs e)
        {
            PaintEventArgs pe = new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle);
            int rows_input = 0;
            int cols_input = 0;
            if(!int.TryParse(textBox_rows.Text, out rows_input))
            {
                MessageBox.Show("行数请输入一个整数！");
                return;
            }
            else if(rows_input >= max_rows || rows_input < 2)
            {
                MessageBox.Show("行数请输入2-" + (max_rows-1).ToString() + "之间的数字！");
                return;
            }
            else
                rows = rows_input;

            if (!int.TryParse(textBox_cols.Text, out cols_input))
            {
                MessageBox.Show("列数请输入一个整数！");
                return;
            }
            else if (cols_input >= max_cols || cols_input < 2)
            {
                MessageBox.Show("列数请输入2-" + (max_cols - 1).ToString() + "之间的数字！");
                return;
            }
            else
                cols = cols_input;

            // 绘制网格
            DrawGrid(pe);
            map = new int [rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    map[i, j] = 0;
        }

        /// <summary>
        /// 开始设置墙壁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_wall_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                mode = 0;
                button_wall.BackColor = Color.SteelBlue;
            }
            else
            {
                mode = 1;
                button_wall.BackColor = Color.Tomato;
                button_road.BackColor = Color.SteelBlue;
                button_start.BackColor = Color.SteelBlue;
                button_end.BackColor = Color.SteelBlue;
            }
        }

        /// <summary>
        /// 开始设置通路
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_road_Click(object sender, EventArgs e)
        {
            if (mode == 2)
            {
                mode = 0;
                button_road.BackColor = Color.SteelBlue;
            }
            else
            {
                mode = 2;
                button_wall.BackColor = Color.SteelBlue;
                button_road.BackColor = Color.Tomato;
                button_start.BackColor = Color.SteelBlue;
                button_end.BackColor = Color.SteelBlue;
            }
        }

        /// <summary>
        /// 开始设置兔子
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            if (mode == 3)
            {
                mode = 0;
                button_start.BackColor = Color.SteelBlue;
            }
            else
            {
                mode = 3;
                button_wall.BackColor = Color.SteelBlue;
                button_road.BackColor = Color.SteelBlue;
                button_start.BackColor = Color.Tomato;
                button_end.BackColor = Color.SteelBlue;
            }
        }

        /// <summary>
        /// 开始设置萝卜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_end_Click(object sender, EventArgs e)
        {
            if (mode == 4)
            {
                mode = 0;
                button_wall.BackColor = Color.SteelBlue;
            }
            else
            {
                mode = 4;
                button_wall.BackColor = Color.SteelBlue;
                button_road.BackColor = Color.SteelBlue;
                button_start.BackColor = Color.SteelBlue;
                button_end.BackColor = Color.Tomato;
            }
        }

        /// <summary>
        /// 点击方格上色 & 窗口拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            if (mode == 0)
                return;
            if (x < left || x > left + width_real || y < top || y > top + height_real)
                return;
            int len_col = width_real / cols;
            int len_row = height_real / rows;
            int row = (y - top) / len_row;
            int col = (x - left) / len_col;

            PaintEventArgs pe = new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle);

            //该块为墙壁
            if (mode == 1)
            {
                if(row == Start.x && col == Start.y)
                {
                    Start.x = -1;
                    Start.y = -1;
                    label_start_position.Text = "还未放置兔子！";
                }
                if (row == Start.x && col == Start.y)
                {
                    End.x = -1;
                    End.y = -1;
                    label_end_position.Text = "还未放置萝卜！";
                }
                map[row, col] = 1;
                Rectangle Rec = new Rectangle(left + col * len_col + 1, top + row * len_row + 1, len_col - 1, len_row - 1);
                pe.Graphics.FillRectangle(new SolidBrush(Color.White), Rec);
            }
            //该块为道路
            if (mode == 2)
            {
                //此处为兔子，无需再修改
                if (row == Start.x && col == Start.y)
                    return;
                //此处为萝卜，无需再修改
                if (row == End.x && col == End.y)
                    return;
                map[row, col] = 0;
                Rectangle Rec = new Rectangle(left + col * len_col + 1, top + row * len_row + 1, len_col - 1, len_row - 1);
                pe.Graphics.FillRectangle(new SolidBrush(Color.SteelBlue), Rec);
            }
            //该块为兔子
            if (mode == 3)
            {
                if (map[row, col] == 1)
                    MessageBox.Show("兔子不能放在墙上！");
                else
                {
                    //尚未存在兔子
                    if(Start.x == -1)
                    {
                        Start.x = row;
                        Start.y = col;
                    }
                    //兔子已存在
                    else
                    {
                        Rectangle Rec_old = new Rectangle(left + Start.y * len_col + 1, top + Start.x * len_row + 1, len_col - 1, len_row - 1);
                        pe.Graphics.FillRectangle(new SolidBrush(Color.SteelBlue), Rec_old);
                        Start.x = row;
                        Start.y = col;
                    }
                    //该处为萝卜
                    if (row == End.x && col == End.y)
                    {
                        End.x = -1;
                        End.y = -1;
                        label_end_position.Text = "还未放置萝卜！";
                    }
                    String str = "( " + (row+1).ToString() + " , " + (col+1).ToString() + " )";
                    label_start_position.Text = str;
                    Rectangle Rec = new Rectangle(left + col * len_col + 1, top + row * len_row + 1, len_col - 1, len_row - 1);
                    pe.Graphics.FillRectangle(new SolidBrush(Color.Tomato), Rec);
                }
            }
            //该块为萝卜
            if (mode == 4)
            {
                if (map[row, col] == 1)
                    MessageBox.Show("萝卜不能放在墙上！");
                else
                {
                    //尚未存在萝卜
                    if (End.x == -1)
                    {
                        End.x = row;
                        End.y = col;
                    }
                    //萝卜已存在
                    else
                    {
                        Rectangle Rec_old = new Rectangle(left + End.y * len_col + 1, top + End.x * len_row + 1, len_col - 1, len_row - 1);
                        pe.Graphics.FillRectangle(new SolidBrush(Color.SteelBlue), Rec_old);
                        End.x = row;
                        End.y = col;
                    }
                    //该处为兔子
                    if (row == Start.x && col == Start.y)
                    {
                        Start.x = -1;
                        Start.y = -1;
                        label_start_position.Text = "还未放置兔子！";
                    }
                    String str = "( " + (row+1).ToString() + " , " + (col+1).ToString() + " )";
                    label_end_position.Text = str;
                    Rectangle Rec = new Rectangle(left + col * len_col + 1, top + row * len_row + 1, len_col - 1, len_row - 1);
                    pe.Graphics.FillRectangle(new SolidBrush(Color.SpringGreen), Rec);
                }
            }
        }

        /// <summary>
        /// 窗口初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            Initial();
        }

        /// <summary>
        /// 确认该点是否可以前进
        /// </summary>
        /// <param name="x">该点横坐标</param>
        /// <param name="y">该点纵坐标</param>
        /// <returns>该点是否可以前进</returns>
        public bool Is_way(int x, int y)
        {
            if (x < 0 || x >= rows || y < 0 || y >= cols)
                return false;
            if (map[x, y] == 1 || map[x,y] == 2)
                return false;
            return true;
        }

        /// <summary>
        /// 开始求解
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_solve_Click(object sender, EventArgs e)
        {
            if(Start.y == -1)
            {
                MessageBox.Show("还未放置兔子！");
                return;
            }
            if(End.x == -1)
            {
                MessageBox.Show("还未放置萝卜！");
                return;
            }
            if(result != null)
            {
                MessageBox.Show("已求解！");
                return;
            }
            //计时器开启
            System.Diagnostics.Stopwatch timer;
            timer = new System.Diagnostics.Stopwatch();

            timer.Start();

            Queue<Node> q = new Queue<Node>();
            Node cur = new Node();
            Node next = new Node();
            string str;

            cur.x = Start.x;
            cur.y = Start.y;
            map[cur.x, cur.y] = 2;
            q.Enqueue(cur);
            while(q.Count != 0)
            {
                cur = q.Dequeue();
                if(cur.x == End.x && cur.y == End.y)
                {
                    result = cur;
                    button_result.BackColor = Color.Tomato;
                    timer.Stop();
                    str = "已经找到通路！\n耗时" + timer.Elapsed.ToString() ;
                    MessageBox.Show(str);
                    str = timer.Elapsed.ToString();
                    label_time_display.Text = str;
                    return;
                }
                int i, next_x, next_y;
                for(i = 0; i < 4; i++)
                {
                    next_x = cur.x + dir_x[i];
                    next_y = cur.y + dir_y[i];
                    if (!Is_way(next_x, next_y))
                        continue;
                    next = new Node();
                    next.x = next_x;
                    next.y = next_y;
                    next.way = new List<int>(cur.way.ToArray());
                    next.way.Add(i);
                    map[next.x, next.y] = 2;
                    q.Enqueue(next);
                }
            }
            str = "没有找到通路！\n耗时" + timer.Elapsed.ToString();
            MessageBox.Show(str);
            str = timer.Elapsed.ToString();
            label_time_display.Text = str;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if(map[i, j] == 2)
                        map[i, j] = 0;
        }

        /// <summary>
        /// 展示结果路线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_result_Click(object sender, EventArgs e)
        {
            if(result == null)
            {
                MessageBox.Show("请先求解道路！");
                return;
            }
            int x, y;
            PaintEventArgs pe = new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle);
            Rectangle Rec = new Rectangle(0, 0, 1, 1);
            SolidBrush paint_way = new SolidBrush(Color.SkyBlue);
            SolidBrush paint_rabbit = new SolidBrush(Color.Tomato);
            int len_col = width_real / cols;
            int len_row = height_real / rows;

            x = Start.x;
            y = Start.y;

            Rec.Width = len_col - 1;
            Rec.Height = len_row - 1;

            for (int i = 0; i < result.way.Count; i++)
            {
                Rec.X = left + y * len_col + 1;
                Rec.Y = top + x * len_row + 1;
                pe.Graphics.FillRectangle(paint_way, Rec);
                x += dir_x[result.way[i]];
                y += dir_y[result.way[i]];
                Rec.X = left + y * len_col + 1;
                Rec.Y = top + x * len_row + 1;
                pe.Graphics.FillRectangle(paint_rabbit, Rec);
                Thread.Sleep(speed);
            }


        }

        /// <summary>
        /// 鼠标按下 开始进行拖动或滑动标记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            x_position = e.X;
            y_position = e.Y;
            if (x_position < left || x_position > left + width_real || y_position < top || y_position > top + height_real)
                isMove = true;
        }

        /// <summary>
        /// 鼠标移动 进行窗口拖动或滑动标记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                int x = e.X;
                int y = e.Y;

                if (x <= left || x >= left + width_real || y <= top || y >= top + height_real)
                {
                    //移动窗体
                    if(e.Button == MouseButtons.Left)
                    {
                        if(isMove)
                            this.SetBounds((MousePosition.X - x_position), (MousePosition.Y - y_position), this.Size.Width, this.Size.Height);
                        return;
                    }
                }
                if (mode == 0)
                    return;
                
                int len_col = width_real / cols;
                int len_row = height_real / rows;
                int row = (y - top) / len_row;
                int col = (x - left) / len_col;

                PaintEventArgs pe = new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle);

                //该块为墙壁
                if (mode == 1)
                {
                    if (row == Start.x && col == Start.y)
                    {
                        Start.x = -1;
                        Start.y = -1;
                        label_start_position.Text = "还未放置兔子！";
                    }
                    if (row == Start.x && col == Start.y)
                    {
                        End.x = -1;
                        End.y = -1;
                        label_end_position.Text = "还未放置萝卜！";
                    }
                    map[row, col] = 1;
                    Rectangle Rec = new Rectangle(left + col * len_col + 1, top + row * len_row + 1, len_col - 1, len_row - 1);
                    pe.Graphics.FillRectangle(new SolidBrush(Color.White), Rec);
                }
                //该块为道路
                if (mode == 2)
                {
                    //此处为兔子，无需再修改
                    if (row == Start.x && col == Start.y)
                        return;
                    //此处为萝卜，无需再修改
                    if (row == End.x && col == End.y)
                        return;
                    map[row, col] = 0;
                    Rectangle Rec = new Rectangle(left + col * len_col + 1, top + row * len_row + 1, len_col - 1, len_row - 1);
                    pe.Graphics.FillRectangle(new SolidBrush(Color.SteelBlue), Rec);
                }
            }
        }

        /// <summary>
        /// 鼠标抬起 结束窗口拖动或滑动标记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            isMove = false;
        }

        /// <summary>
        /// 退出键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 打开帮助页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }

    //记录兔子位置
    public class Position
    {
        public int x;
        public int y;

        public Position()
        {
            x = -1;
            y = -1;
        }
    }

    //用于搜索算法
    public class Node
    {
        public int x;
        public int y;
        public List<int> way;

        public Node()
        {
            x = -1;
            y = -1;
            way = new List<int>();
        }
    }
}
