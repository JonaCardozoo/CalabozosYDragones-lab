﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab
{
    public partial class PantallaCarga : Form
    {
        public PantallaCarga()
        {
            InitializeComponent();
        }
        public PantallaCarga(int segundos)
        {
            InitializeComponent();
            
            timer1.Interval = segundos * 1000;
            timer1.Start();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Stop();
            this.Close();
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(7);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer2.Stop();
                this.Hide();
                
            }
        }
    }
}
