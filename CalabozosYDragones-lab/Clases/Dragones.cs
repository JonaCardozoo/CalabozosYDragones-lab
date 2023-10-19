using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab
{
    internal class Dragones : Pieza
    {
        
        public int Numero {get; set; }
        

        public int OpcionDragones { get; set; }

        static Random moverDragones = new Random();
        public Dragones(int posicion): base(posicion) 
        { 
           base.Posicion = posicion;          
        }

        public override void Jugar(Panel Dragon1, Panel Dragon2)
        {

            switch (OpcionDragones)
            {
                case 1:

                    PosicionDragonRosa1 = MoverDragon();
                    ColumnaDragonRosa1 = (PosicionDragonRosa1 % 10) * 90;
                    FilaDragonRosa1 = (PosicionDragonRosa1 / 10) * 90;
                    Dragon1.Left = 55 + ColumnaDragonRosa1;
                    Dragon1.Top = 65 + FilaDragonRosa1;

                    PosicionDragonRosa2 = MoverDragon();
                    ColumnaDragonRosa2 = (PosicionDragonRosa2 % 10) * 90;
                    FilaDragonRosa2 = (PosicionDragonRosa2 / 10) * 90;
                    Dragon2.Left = 55 + ColumnaDragonRosa2;
                    Dragon2.Top = 65 + FilaDragonRosa2;

                    break;
                case 2:

                    PosicionDragonAzul1 = MoverDragon();
                    ColumnaDragonAzul1 = (PosicionDragonAzul1 % 10) * 90;
                    FilaDragonAzul1 = (PosicionDragonAzul1 / 10) * 90;
                    Dragon1.Left = 55 + ColumnaDragonAzul1;
                    Dragon1.Top = 65 + FilaDragonAzul1;

                    PosicionDragonAzul2 = MoverDragon();
                    ColumnaDragonAzul2 = (PosicionDragonAzul2 % 10) * 90;
                    FilaDragonAzul2 = (PosicionDragonAzul2 / 10) * 90;
                    Dragon2.Left = 55 + ColumnaDragonAzul2;
                    Dragon2.Top = 65 + FilaDragonAzul2;


                    break;

                case 3:

                    PosicionDragonAmarillo1 = MoverDragon();
                    ColumnaDragonAmarillo1 = (PosicionDragonAmarillo1 % 10) * 90;
                    FilaDragonAmarillo1 = (PosicionDragonAmarillo1 / 10) * 90;
                    Dragon1.Left = 55 + ColumnaDragonAmarillo1;
                    Dragon1.Top = 65 + FilaDragonAmarillo1;

                    PosicionDragonAmarillo2 = MoverDragon();
                    ColumnaDragonAmarillo2 = (PosicionDragonAmarillo2 % 10) * 90;
                    FilaDragonAmarillo2 = (PosicionDragonAmarillo2 / 10) * 90;
                    Dragon2.Left = 55 + ColumnaDragonAmarillo2;
                    Dragon2.Top = 65 + FilaDragonAmarillo2;

                    break;

                case 4:

                    PosicionDragonVerde1 = MoverDragon();
                    ColumnaDragonVerde1 = (PosicionDragonVerde1 % 10) * 90;
                    FilaDragonVerde1 = (PosicionDragonVerde1 / 10) * 90;
                    Dragon1.Left = 55 + ColumnaDragonVerde1;
                    Dragon1.Top = 65 + FilaDragonVerde1;

                    PosicionDragonVerde2 = MoverDragon();
                    ColumnaDragonVerde2 = (PosicionDragonVerde2 % 10) * 90;
                    FilaDragonVerde2 = (PosicionDragonVerde2 / 10) * 90;
                    Dragon2.Left = 55 + ColumnaDragonVerde2;
                    Dragon2.Top = 65 + FilaDragonVerde2;

                    break;

            }
        }

        public override int MoverPieza()
        {
            return 1;
        }
        
        public int MoverDragon()
        {
            Numero = moverDragones.Next(1,49);
            return Numero;

        }

        

    }
}
