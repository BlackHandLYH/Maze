namespace Maze
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox_rows = new System.Windows.Forms.TextBox();
            this.textBox_cols = new System.Windows.Forms.TextBox();
            this.button_shape = new System.Windows.Forms.Button();
            this.label_rows = new System.Windows.Forms.Label();
            this.label_cols = new System.Windows.Forms.Label();
            this.button_wall = new System.Windows.Forms.Button();
            this.button_road = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_end = new System.Windows.Forms.Button();
            this.label_start = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_start_position = new System.Windows.Forms.Label();
            this.label_end_position = new System.Windows.Forms.Label();
            this.button_solve = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.pictureBox_title = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_time_display = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_title)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_rows
            // 
            this.textBox_rows.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox_rows.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_rows.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_rows.ForeColor = System.Drawing.Color.White;
            this.textBox_rows.Location = new System.Drawing.Point(508, 94);
            this.textBox_rows.Name = "textBox_rows";
            this.textBox_rows.Size = new System.Drawing.Size(130, 26);
            this.textBox_rows.TabIndex = 0;
            this.textBox_rows.Text = "8";
            this.textBox_rows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_rows.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_rows_MouseClick);
            // 
            // textBox_cols
            // 
            this.textBox_cols.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox_cols.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_cols.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_cols.ForeColor = System.Drawing.Color.White;
            this.textBox_cols.Location = new System.Drawing.Point(508, 121);
            this.textBox_cols.Name = "textBox_cols";
            this.textBox_cols.Size = new System.Drawing.Size(130, 26);
            this.textBox_cols.TabIndex = 1;
            this.textBox_cols.Text = "8";
            this.textBox_cols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_cols.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_cols_MouseClick);
            // 
            // button_shape
            // 
            this.button_shape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shape.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_shape.ForeColor = System.Drawing.Color.White;
            this.button_shape.Location = new System.Drawing.Point(415, 152);
            this.button_shape.Name = "button_shape";
            this.button_shape.Size = new System.Drawing.Size(223, 33);
            this.button_shape.TabIndex = 2;
            this.button_shape.Text = "绘制地图";
            this.button_shape.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_shape.UseVisualStyleBackColor = true;
            this.button_shape.Click += new System.EventHandler(this.button_shape_Click);
            // 
            // label_rows
            // 
            this.label_rows.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_rows.ForeColor = System.Drawing.Color.White;
            this.label_rows.Location = new System.Drawing.Point(401, 94);
            this.label_rows.Name = "label_rows";
            this.label_rows.Size = new System.Drawing.Size(102, 26);
            this.label_rows.TabIndex = 3;
            this.label_rows.Text = "请输入行数：";
            this.label_rows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_cols
            // 
            this.label_cols.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_cols.ForeColor = System.Drawing.Color.White;
            this.label_cols.Location = new System.Drawing.Point(400, 120);
            this.label_cols.Name = "label_cols";
            this.label_cols.Size = new System.Drawing.Size(102, 26);
            this.label_cols.TabIndex = 4;
            this.label_cols.Text = "请输入列数：";
            this.label_cols.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_wall
            // 
            this.button_wall.BackColor = System.Drawing.Color.SteelBlue;
            this.button_wall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_wall.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_wall.ForeColor = System.Drawing.Color.White;
            this.button_wall.Location = new System.Drawing.Point(415, 191);
            this.button_wall.Name = "button_wall";
            this.button_wall.Size = new System.Drawing.Size(70, 70);
            this.button_wall.TabIndex = 5;
            this.button_wall.Text = "设置\r\n墙壁";
            this.button_wall.UseVisualStyleBackColor = false;
            this.button_wall.Click += new System.EventHandler(this.button_wall_Click);
            // 
            // button_road
            // 
            this.button_road.BackColor = System.Drawing.Color.SteelBlue;
            this.button_road.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_road.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_road.ForeColor = System.Drawing.Color.White;
            this.button_road.Location = new System.Drawing.Point(491, 191);
            this.button_road.Name = "button_road";
            this.button_road.Size = new System.Drawing.Size(70, 70);
            this.button_road.TabIndex = 6;
            this.button_road.Text = "设置\r\n道路";
            this.button_road.UseVisualStyleBackColor = false;
            this.button_road.Click += new System.EventHandler(this.button_road_Click);
            // 
            // button_start
            // 
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.ForeColor = System.Drawing.Color.White;
            this.button_start.Location = new System.Drawing.Point(415, 267);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(70, 70);
            this.button_start.TabIndex = 7;
            this.button_start.Text = "设置\r\n兔子";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_end
            // 
            this.button_end.BackColor = System.Drawing.Color.SteelBlue;
            this.button_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_end.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_end.ForeColor = System.Drawing.Color.White;
            this.button_end.Location = new System.Drawing.Point(491, 267);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(70, 70);
            this.button_end.TabIndex = 8;
            this.button_end.Text = "设置\r\n萝卜";
            this.button_end.UseVisualStyleBackColor = false;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
            // 
            // label_start
            // 
            this.label_start.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_start.ForeColor = System.Drawing.Color.White;
            this.label_start.Location = new System.Drawing.Point(403, 352);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(102, 26);
            this.label_start.TabIndex = 9;
            this.label_start.Text = "兔子位置：";
            this.label_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(403, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "萝卜位置：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_start_position
            // 
            this.label_start_position.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_start_position.ForeColor = System.Drawing.Color.White;
            this.label_start_position.Location = new System.Drawing.Point(489, 352);
            this.label_start_position.Name = "label_start_position";
            this.label_start_position.Size = new System.Drawing.Size(121, 26);
            this.label_start_position.TabIndex = 11;
            this.label_start_position.Text = "还未放置兔子！";
            this.label_start_position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_end_position
            // 
            this.label_end_position.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_end_position.ForeColor = System.Drawing.Color.White;
            this.label_end_position.Location = new System.Drawing.Point(489, 376);
            this.label_end_position.Name = "label_end_position";
            this.label_end_position.Size = new System.Drawing.Size(126, 26);
            this.label_end_position.TabIndex = 12;
            this.label_end_position.Text = "还未放置萝卜！";
            this.label_end_position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_solve
            // 
            this.button_solve.BackColor = System.Drawing.Color.SteelBlue;
            this.button_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_solve.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_solve.ForeColor = System.Drawing.Color.White;
            this.button_solve.Location = new System.Drawing.Point(567, 191);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(70, 70);
            this.button_solve.TabIndex = 13;
            this.button_solve.Text = "求解\r\n道路";
            this.button_solve.UseVisualStyleBackColor = false;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // button_result
            // 
            this.button_result.BackColor = System.Drawing.Color.SteelBlue;
            this.button_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_result.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_result.ForeColor = System.Drawing.Color.White;
            this.button_result.Location = new System.Drawing.Point(567, 267);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(70, 70);
            this.button_result.TabIndex = 14;
            this.button_result.Text = "查看\r\n道路";
            this.button_result.UseVisualStyleBackColor = false;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.SteelBlue;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(619, 11);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(35, 35);
            this.button_exit.TabIndex = 15;
            this.button_exit.Text = "╳";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_help
            // 
            this.button_help.BackColor = System.Drawing.Color.SteelBlue;
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_help.ForeColor = System.Drawing.Color.White;
            this.button_help.Location = new System.Drawing.Point(578, 11);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(35, 35);
            this.button_help.TabIndex = 16;
            this.button_help.Text = "?";
            this.button_help.UseVisualStyleBackColor = false;
            this.button_help.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_title
            // 
            this.pictureBox_title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_title.BackgroundImage")));
            this.pictureBox_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_title.Location = new System.Drawing.Point(415, 11);
            this.pictureBox_title.Name = "pictureBox_title";
            this.pictureBox_title.Size = new System.Drawing.Size(70, 74);
            this.pictureBox_title.TabIndex = 17;
            this.pictureBox_title.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(171, 21);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(52, 36);
            this.label_title.TabIndex = 19;
            this.label_title.Text = "吃";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(109, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 36);
            this.label2.TabIndex = 20;
            this.label2.Text = "兔子";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(210, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 36);
            this.label3.TabIndex = 21;
            this.label3.Text = "胡萝卜";
            // 
            // label_time
            // 
            this.label_time.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(403, 400);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(102, 26);
            this.label_time.TabIndex = 22;
            this.label_time.Text = "搜索时间：";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_time_display
            // 
            this.label_time_display.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time_display.ForeColor = System.Drawing.Color.White;
            this.label_time_display.Location = new System.Drawing.Point(489, 400);
            this.label_time_display.Name = "label_time_display";
            this.label_time_display.Size = new System.Drawing.Size(126, 26);
            this.label_time_display.TabIndex = 23;
            this.label_time_display.Text = "尚未搜索";
            this.label_time_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.label_time_display);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_title);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.label_end_position);
            this.Controls.Add(this.label_start_position);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_road);
            this.Controls.Add(this.button_wall);
            this.Controls.Add(this.label_cols);
            this.Controls.Add(this.label_rows);
            this.Controls.Add(this.button_shape);
            this.Controls.Add(this.textBox_cols);
            this.Controls.Add(this.textBox_rows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_rows;
        private System.Windows.Forms.TextBox textBox_cols;
        private System.Windows.Forms.Button button_shape;
        private System.Windows.Forms.Label label_rows;
        private System.Windows.Forms.Label label_cols;
        private System.Windows.Forms.Button button_wall;
        private System.Windows.Forms.Button button_road;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_start_position;
        private System.Windows.Forms.Label label_end_position;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.PictureBox pictureBox_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_time_display;
    }
}

