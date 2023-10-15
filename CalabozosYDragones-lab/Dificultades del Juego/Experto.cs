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
        override public void Jugar()
        {
            base.Jugar();
            for (int i = 0; i < caballeros.Length; i++)
            {
                Caballero jug = (Caballero)caballeros[i];

                if (jug.Turno <= 0)
                {
                    for (int n = 0; n < calabozos.Length && jug.Turno <= 0; n++)
                    {
                        foreach (Dragones drag in dragones)
                        {
                            Calabozo aux = (Calabozo)calabozos[n];
                            if (aux.Cala == jug.Posicion)
                            {
                                jug.Turno = 1;
                                if (jug.Posicion == drag.Posicion)
                                {
                                    jug.Turno = 0;
                                }
                                else if (jug.Posicion== drag.Posicion)
                                {
                                    //caballeros.Remove(jug);
                                }
                            }
                        }
                    }
                }
                else
                {
                    jug.Turno--;
                }

            }
        }
    }
}

