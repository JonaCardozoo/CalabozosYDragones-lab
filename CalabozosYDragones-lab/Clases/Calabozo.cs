using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab.Clases
{
    internal class Calabozo
    { 
        public Panel Cala { get; set; }
        Random random = new Random();
        public void PosicionCala(Panel Calabozo)
        {
            int pos = random.Next(1,49);
            Calabozo.Left = 47 +((pos % 10) * 90);
            Calabozo.Top = 55 + ((pos / 10) * 90);
        }
        public void PosicionInicialCala(Panel Calabozo)
        {
            Calabozo.Left = 35;
            Calabozo.Top = 50;
        }
        public Calabozo(Panel posicion)
        {
            Cala = posicion;
        }
        

    }
}
