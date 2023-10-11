using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab
{
    abstract class Pieza
    {

        public int Posicion { get; protected set; }

        protected static int PosicionRosado = 0;
        protected static int PosicionAzul = 0;
        protected static int PosicionAmarillo = 0;
        protected static int PosicionVerde = 0;

        protected int ColumnaRosado = 0;
        protected int FilaRosado = 0;
        protected int ColumnaAzul = 0;
        protected int FilaAzul = 0;
        protected int ColumnaAmarillo = 0;
        protected int FilaAmarillo = 0;
        protected int ColumnaVerde = 0;
        protected int FilaVerde = 0;

        protected static int PosicionDragonRosa1 = 0;
        protected static int PosicionDragonRosa2 = 0;
        protected static int PosicionDragonAzul1 = 0;
        protected static int PosicionDragonAzul2 = 0;
        protected static int PosicionDragonAmarillo1 = 0;
        protected static int PosicionDragonAmarillo2 = 0;
        protected static int PosicionDragonVerde1 = 0;
        protected static int PosicionDragonVerde2 = 0;


        protected int FilaDragonRosa1 = 0;
        protected int ColumnaDragonRosa1 = 0;
        protected int FilaDragonRosa2 = 0;
        protected int ColumnaDragonRosa2 = 0;
        protected int FilaDragonAzul1 = 0;
        protected int ColumnaDragonAzul1 = 0;
        protected int FilaDragonAzul2 = 0;
        protected int ColumnaDragonAzul2 = 0;
        protected int FilaDragonAmarillo1 = 0;
        protected int ColumnaDragonAmarillo1 = 0;
        protected int FilaDragonAmarillo2 = 0;
        protected int ColumnaDragonAmarillo2 = 0;
        protected int FilaDragonVerde1 = 0;
        protected int ColumnaDragonVerde1 = 0;
        protected int FilaDragonVerde2 = 0;
        protected int ColumnaDragonVerde2 = 0;


        public Pieza(int posicion)
        {
            Posicion = posicion;      
        }

        public abstract int MoverPieza();

        //public abstract int JugarDragon();    
        public abstract void Jugar(Panel Piezas,Panel piezas);
        

    }
}
