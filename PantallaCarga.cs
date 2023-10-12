using System;
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
        int contador = 0;
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
            //BarraDeCarga.Value += 10;
            //contador+= 10;
            //label1.Text = contador + "%";

            //if(BarraDeCarga.Value == 100)
            //{
            //    timer1.Stop();
            //}
            //if(contador < 100)
            //{
            //    contador++;
            //    label1.Text = contador++.ToString();
            //    BarraDeCarga.Increment(contador);
            //}
            //else
            //{
            //    timer1.Stop();
            //}

            //progressBar1.Increment(10);
            //if (progressBar1.Value == progressBar1.Maximum)
            //{
            //    timer2.Stop();
            //    this.Hide();
                
            //}

        }
    }
}
