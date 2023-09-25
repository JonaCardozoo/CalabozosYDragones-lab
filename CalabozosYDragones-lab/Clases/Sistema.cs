using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.Linq.Expressions;

namespace CalabozosYDragones_lab
{
    internal class Sistema
    {
        

        Random LugarRandom = new Random();
        string[] jugador = new string[1];
        int contador = 0;
        string Nombre { get; set; }
            
        public Sistema()
        {

            Jugador jugadorHumano = new Jugador(Nombre);
            Jugador Maquina1 = new Jugador("Maquina1");
            Jugador Maquina2 = new Jugador("Maquina2");
            Jugador Maquina3 = new Jugador("Maquina3");

        }

        public void AgregarJugador(string nombre)
        {
            jugador[contador++] = nombre;   
        }

        public override string ToString()
        {
            return jugador.ToString();
        }

    }
}
