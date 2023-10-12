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
    public partial class GameOver : Form
    {
        
        public GameOver()
        {
            InitializeComponent();
            
        }

        public GameOver(int segundos)
        {
            InitializeComponent();

            TimerGameOver.Interval = segundos * 1000;
            TimerGameOver.Start();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }

        private void TimerGameOver_Tick(object sender, EventArgs e)
        {
            TimerGameOver.Stop();
            this.Close();

        }
    }
}
