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
        
        public int Cala { get; set; }
        public Random PosicionCalabozo = new Random();

        public Calabozo(int posicion)
        {
            Cala = posicion;
        }

        public int PosLeft()
        {
            int ran = PosicionCalabozo.Next(1, 49);
            int left = 55 + ((ran % 10) * 90);
            return left;

        }
        public int PosTop()
        {
            int ran = PosicionCalabozo.Next(1, 49);
            int top = 70 + ((ran / 10) * 90);
            return top;
        }

    }
}


    

