﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pgb
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100001;
            int sayi;
            for( sayi=0; sayi<100001; sayi++)
            {
                progressBar1.Value = sayi;
                listBox1.Items.Add(sayi);
            }
        }
    }
}