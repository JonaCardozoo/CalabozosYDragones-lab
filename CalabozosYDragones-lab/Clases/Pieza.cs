using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab
{
    internal class Pieza
    {

        public Panel Posicion { get; protected set; }

        public Pieza(Panel posicion)
        {
            Posicion = posicion;      
        }

    }
}
