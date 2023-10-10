using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab
{
    internal class Basico
    {

        public int Posicion { get; set; }
        int cantidadJugadores = 0;
        
        public int Numero { get; set; }

        public Basico(int posicion,int cantidadJugadores)
        {

            Posicion = posicion;
            this.cantidadJugadores = cantidadJugadores;
             
        }




    }
}
