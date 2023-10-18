using CalabozosYDragones_lab.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab
{

    internal class Experto : Intermedio
    {
        Calabozo[] calabozos = new Calabozo[3];
        
        public Experto(int posicion, int cantidad) : base(posicion, cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                calabozos[i] = new Calabozo(posicion);
            }
        }
        
    }
}

