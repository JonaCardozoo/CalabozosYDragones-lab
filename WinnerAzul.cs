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
    public partial class WinnerAzul : Form
    {
        public WinnerAzul()
        {
            InitializeComponent();
        }

        public WinnerAzul(int seg)
        {
            InitializeComponent();

            TimerSplash.Interval = seg*1000;
            TimerSplash.Start();
        }
        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            TimerSplash.Stop();
            this.Close();
        }
    }
}
