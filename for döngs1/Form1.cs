﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_döngs1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i =110; i >= 10; i-= 10)
            {
                listBox2.Items.Add(i);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 10; i <= 110; i+=10)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
