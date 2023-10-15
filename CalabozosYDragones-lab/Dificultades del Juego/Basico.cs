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
        Caballero caballero;
        public int Numero { get; set; }
        protected Caballero[] caballeros = new Caballero[4];
        public Basico(int posicion,int cantidadJugadores)
        {
            caballero = new Caballero(posicion);
            Posicion = posicion;
            this.cantidadJugadores = cantidadJugadores;

            for (int i = 0; i < caballeros.Length; i++)
            {
                if (caballeros != null)
                {
                    caballeros[i] = caballero;
                }
                
            }
             
        }
        virtual public void Jugar() 

        {
            foreach (Caballero jug in caballeros)
            {
                if (jug.Turno < 1)
                {
                    jug.MoverPieza();
                }
                
            }
        }

        public void PosicionInicialCaballero(Panel caballeros)
        {
            caballeros.Left = 35;
            caballeros.Top = 50;

        }




    }
}
