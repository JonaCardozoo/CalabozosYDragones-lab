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

        protected Dragones[] dragones = new Dragones[8];  
        int contador = 0;
        
        public Intermedio(int posicion, int cantidadJugadores) : base(posicion,cantidadJugadores)
        {
            int cantDragones = cantidadJugadores * 2;
            for (int i = 0; i < cantDragones; i++)
            {
                dragones[i] = new Dragones(posicion);
            }

        }
        public override void Jugar()
        {
            base.Jugar();
            foreach (Dragones dragon in dragones)
            {
                foreach (Caballero a in caballeros)
                {

                    dragon.MoverPieza();
                    
                }
            }
        }
        public void PosicionInicialDragones(Panel dragon1, Panel Dragon2)
        {
            dragon1.Left = 35;
            Dragon2.Top = 50;

        }

    }
}
