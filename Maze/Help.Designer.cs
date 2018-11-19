namespace Maze
{
    partial class Help
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.button_exit = new System.Windows.Forms.Button();
            this.label_help = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_wall = new System.Windows.Forms.Label();
            this.label_road = new System.Windows.Forms.Label();
            this.label_rabbit = new System.Windows.Forms.Label();
            this.label_carrot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.SteelBlue;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(471, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(35, 35);
            this.button_exit.TabIndex = 16;
            this.button_exit.Text = "╳";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_help
            // 
            this.label_help.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_help.ForeColor = System.Drawing.Color.White;
            this.label_help.Location = new System.Drawing.Point(7, 62);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(505, 248);
            this.label_help.TabIndex = 17;
            this.label_help.Text = resources.GetString("label_help.Text");
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(10, 19);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(133, 36);
            this.label_title.TabIndex = 18;
            this.label_title.Text = "- 操作方法 -";
            // 
            // label_wall
            // 
            this.label_wall.BackColor = System.Drawing.Color.White;
            this.label_wall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_wall.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_wall.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_wall.Location = new System.Drawing.Point(146, 323);
            this.label_wall.Name = "label_wall";
            this.label_wall.Size = new System.Drawing.Size(60, 60);
            this.label_wall.TabIndex = 19;
            this.label_wall.Text = "墙壁";
            this.label_wall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_road
            // 
            this.label_road.BackColor = System.Drawing.Color.SteelBlue;
            this.label_road.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_road.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_road.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_road.ForeColor = System.Drawing.Color.White;
            this.label_road.Location = new System.Drawing.Point(233, 323);
            this.label_road.Name = "label_road";
            this.label_road.Size = new System.Drawing.Size(60, 60);
            this.label_road.TabIndex = 20;
            this.label_road.Text = "通路";
            this.label_road.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_rabbit
            // 
            this.label_rabbit.BackColor = System.Drawing.Color.Tomato;
            this.label_rabbit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_rabbit.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_rabbit.ForeColor = System.Drawing.Color.White;
            this.label_rabbit.Location = new System.Drawing.Point(321, 323);
            this.label_rabbit.Name = "label_rabbit";
            this.label_rabbit.Size = new System.Drawing.Size(60, 60);
            this.label_rabbit.TabIndex = 21;
            this.label_rabbit.Text = "兔子";
            this.label_rabbit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_carrot
            // 
            this.label_carrot.BackColor = System.Drawing.Color.SpringGreen;
            this.label_carrot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_carrot.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_carrot.ForeColor = System.Drawing.Color.White;
            this.label_carrot.Location = new System.Drawing.Point(409, 323);
            this.label_carrot.Name = "label_carrot";
            this.label_carrot.Size = new System.Drawing.Size(60, 60);
            this.label_carrot.TabIndex = 22;
            this.label_carrot.Text = "萝卜";
            this.label_carrot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "- 颜色意义 -";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(518, 416);
            this.Controls.Add(this.label_carrot);
            this.Controls.Add(this.label_rabbit);
            this.Controls.Add(this.label_road);
            this.Controls.Add(this.label_wall);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Help_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Help_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Help_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Help_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_wall;
        private System.Windows.Forms.Label label_road;
        private System.Windows.Forms.Label label_rabbit;
        private System.Windows.Forms.Label label_carrot;
        private System.Windows.Forms.Label label1;
    }
}