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

                //case 3:

                //    PosicionAmarillo += MoverDragon();
                //    ColumnaAmarillo = (PosicionAmarillo % 10) * 90;
                //    FilaAmarillo = (PosicionAmarillo / 10) * 90;
                //    Caballeros.Left = 55 + ColumnaAmarillo;
                //    Caballeros.Top = 65 + FilaAmarillo;

                //    break;

                //case 4:

                //    PosicionVerde += MoverDragon();
                //    ColumnaVerde = (PosicionVerde % 10) * 90;
                //    FilaVerde = (PosicionVerde / 10) * 90;
                //    Caballeros.Left = 55 + ColumnaVerde;
                //    Caballeros.Top = 65 + FilaVerde;

                //    break;

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
