﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CalabozosYDragones_lab
{
    internal class Pieza
    {

        public int Posicion { get; protected set; }

        public Pieza(int posicion)
        {
            Posicion = posicion;
            posicion = 0;
        }


    }
}
