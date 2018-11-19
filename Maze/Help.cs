using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Help : Form
    {
        public bool isMove = false;
        public int x = 0;
        public int y = 0;

        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            x = e.X;
            y = e.Y;
        }

        private void Help_MouseMove(object sender, MouseEventArgs e)
        {
            //移动窗体
            if (e.Button == MouseButtons.Left)
            {
                if (isMove)
                    this.SetBounds((MousePosition.X - x), (MousePosition.Y - y), this.Size.Width, this.Size.Height);
                return;
            }
        }

        private void Help_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
