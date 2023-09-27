using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab.Clases
{
    internal class Intermedio:Basico
    {

        Dragones[] dragones = new Dragones[8];  
        int contador = 0;
        

        public Intermedio(int posicion, int cantidadJugadores) : base(posicion,cantidadJugadores)
        {
            int cantDragones = cantidadJugadores * 2;
            for (int i = 0; i < cantDragones; i++)
            {
                dragones[i] = new Dragones(posicion);
            }

        }

        public void CrearDragon(Dragones nuevoDragon)
        {
            dragones[contador++] = nuevoDragon;
        }


    }
}
