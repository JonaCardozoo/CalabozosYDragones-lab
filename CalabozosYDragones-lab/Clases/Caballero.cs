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

        static int PosicionRosado = 0;
        static int PosicionAzul = 0;
        public int TurnoCaballero { get; set; }
        static Random Movilizar = new Random();
        public int Numero {  get; set; }

        public int ColumnaRosado = 0;
        public int FilaRosado = 0;
        public int ColumnaAzul = 0;
        public int FilaAzul = 0;

        Basico basico;
        Panel caballeroRosa = new Panel();
        public Caballero(int posicion): base(posicion)
        {
            Posicion = posicion;
        }

        public void PosicionInicialCaballero(Panel caballeros)
        {
            caballeros.Left = 35;
            caballeros.Top = 50;

        }

        public override int MoverPieza()
        {
            Numero = Movilizar.Next(1, 7);
            return Numero;
        }

        public bool HayGanador()
        {
            return true;

        }

        public override void Jugar(Panel Caballeros,Panel caballero)
        {

            switch (TurnoCaballero)
            {
                case 1:

                    PosicionRosado += MoverPieza();
                    ColumnaRosado = (PosicionRosado % 10) * 90;
                    FilaRosado = (PosicionRosado / 10) * 90;
                    Caballeros.Left = 55 + ColumnaRosado;
                    Caballeros.Top = 65 + FilaRosado;
                    break;
                case 2:
                    PosicionAzul += MoverPieza();
                    ColumnaAzul = (PosicionAzul % 10) * 90;
                    FilaAzul = (PosicionAzul / 10) * 90;
                    caballero.Left = 55 + ColumnaAzul;
                    caballero.Top = 65 + FilaAzul;
                    break;

            }
            

        }

    }

}
