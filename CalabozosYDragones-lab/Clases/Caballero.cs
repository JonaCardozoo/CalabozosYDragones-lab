using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab
{
    internal class Caballero:Pieza 
    {

        
        public int TurnoCaballero { get; set; }
        static Random Movilizar = new Random();

        public int Turno = 0;

        public int Numero {  get; set; }
        public bool hayGanador = false;
        

        Basico basico;
        Panel caballeroRosa = new Panel();
        public Caballero(int posicion): base(posicion)
        {
            Posicion = posicion;
        }

        
        public override int MoverPieza()
        {
            Numero = Movilizar.Next(1, 7);
            return Numero;
        }

        public override void Jugar(Panel Caballeros,Panel caballeros)
        {
            basico = new Basico(1,3);
            switch (TurnoCaballero)
            {
                case 1:
                    
                    PosicionRosado += MoverPieza();
                    ColumnaRosado = (PosicionRosado % 10) * 90;
                    FilaRosado = (PosicionRosado / 10) * 90;
                    Caballeros.Left = 55 + ColumnaRosado;
                    Caballeros.Top = 65 + FilaRosado;

                    bool MismoLugar = false;

                    if (PosicionRosado == PosicionDragonRosa1)
                    {
                        MismoLugar = true;
                        PosicionRosado += 5;

                    }

                    break;
                case 2:
                    PosicionAzul += MoverPieza();
                    ColumnaAzul = (PosicionAzul % 10) * 90;
                    FilaAzul = (PosicionAzul / 10) * 90;
                    Caballeros.Left = 55 + ColumnaAzul;
                    Caballeros.Top = 65 + FilaAzul;
                    break;

                case 3:

                    PosicionAmarillo += MoverPieza();
                    ColumnaAmarillo = (PosicionAmarillo % 10) * 90;
                    FilaAmarillo = (PosicionAmarillo / 10) * 90;
                    Caballeros.Left = 55 + ColumnaAmarillo;
                    Caballeros.Top = 65 + FilaAmarillo;

                    break;

                case 4:

                    PosicionVerde += MoverPieza();
                    ColumnaVerde = (PosicionVerde % 10) * 90;
                    FilaVerde = (PosicionVerde / 10) * 90;
                    Caballeros.Left = 55 + ColumnaVerde;
                    Caballeros.Top = 65 + FilaVerde;

                    break;

            }

        }

        public bool VerficarGanador()
        {
            
            if (PosicionRosado >= 49)
            {
                hayGanador = true;
                PosicionRosado = 0;
                PosicionVerde = 0;
                PosicionAzul = 0;
                PosicionAmarillo = 0;

            }

            else if (PosicionAzul >= 49)
            {
                hayGanador = true;
                PosicionRosado = 0;
                PosicionVerde = 0;
                PosicionAzul = 0;
                PosicionAmarillo = 0;

            }

            else if (PosicionAmarillo >= 49)
            {
                hayGanador = true;
                PosicionRosado = 0;
                PosicionVerde = 0;
                PosicionAzul = 0;
                PosicionAmarillo = 0;

            }

            else if(PosicionVerde>=49)
            {
                hayGanador = true;
                PosicionRosado = 0;
                PosicionVerde = 0;
                PosicionAzul = 0;
                PosicionAmarillo = 0;

            }

            return hayGanador;


        }

    }

}
