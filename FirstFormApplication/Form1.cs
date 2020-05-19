﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            myButton.Enabled = true;
            myButton.Text = "코드에서 변경!";
            myButton.Width = 200;

            for(int i=0; i< 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);

                button.Location = new Point(220, 13 + (23 + 3) * i);
                button.Text = "동정 생성 " + i + "번째";
            }
        }
    }
}
