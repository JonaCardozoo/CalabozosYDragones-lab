using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CalabozosYDragones_lab
{
    internal class Jugador
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
        }
        public Jugador(string nombreJugador)
        {
            nombre = nombreJugador;
        }

       public override string ToString()
        {
            return nombre;
        }

    }
}
