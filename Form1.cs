﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath _path = new System.Drawing.Drawing2D.GraphicsPath();
            _path.AddEllipse(new Rectangle(0, 0, 50, 50));
            pictureBox1.Region = new Region(_path);//改變形狀
        }
    }
}
