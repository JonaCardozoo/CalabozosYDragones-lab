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

        public bool MismoLugarAliadoRosa = false;
        public bool MismoLugarAliadoAzul = false;
        public bool MismoLugarAliadoAmarillo = false;
        public bool MismoLugarAliadoVerde = false;

        public bool MismoLugarEnemigoRosa = false;
        public bool MismoLugarEnemigoAzul = false;
        public bool MismoLugarEnemigoAmarillo = false;
        public bool MismoLugarEnemigoVerde = false;



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

                    if (PosicionRosado == PosicionDragonRosa1)
                    {
                        MismoLugarAliadoRosa = true;
                        PosicionRosado += 5;
                    }

                    else if (PosicionRosado == PosicionDragonRosa2)
                    {
                        MismoLugarAliadoRosa = true;
                        PosicionRosado += 5;
                    }

                    else if (PosicionRosado == PosicionDragonAzul1)
                    {
                        MismoLugarEnemigoRosa = true;
                        PosicionRosado -= 5;

                    }

                    else if (PosicionRosado == PosicionDragonAzul2)
                    {
                        MismoLugarEnemigoRosa = true;
                        PosicionRosado -= 5;
                    }

                    break;
                case 2:
                    PosicionAzul += MoverPieza();
                    ColumnaAzul = (PosicionAzul % 10) * 90;
                    FilaAzul = (PosicionAzul / 10) * 90;
                    Caballeros.Left = 55 + ColumnaAzul;
                    Caballeros.Top = 65 + FilaAzul;

                    if (PosicionAzul == PosicionDragonAzul1)
                    {
                        MismoLugarAliadoAzul = true;
                        PosicionAzul += 5;

                    }

                    if (PosicionAzul == PosicionDragonAzul2)
                    {
                        MismoLugarAliadoAzul = true;
                        PosicionAzul += 5;

                    }

                    else if (PosicionRosado == PosicionDragonRosa1)
                    {
                        MismoLugarEnemigoAzul = true;
                        PosicionAzul -= 5;
                    }
                    else if (PosicionRosado == PosicionDragonRosa1)
                    {
                        MismoLugarEnemigoAzul = true;
                        PosicionAzul -= 5;

                    }


                    break;

                case 3:

                    PosicionAmarillo += MoverPieza();
                    ColumnaAmarillo = (PosicionAmarillo % 10) * 90;
                    FilaAmarillo = (PosicionAmarillo / 10) * 90;
                    Caballeros.Left = 55 + ColumnaAmarillo;
                    Caballeros.Top = 65 + FilaAmarillo;

                    if (PosicionAmarillo == PosicionDragonAmarillo1)
                    {
                        MismoLugarAliadoAmarillo = true;
                        PosicionAmarillo += 5;

                    }

                    if (PosicionAmarillo== PosicionDragonAmarillo2)
                    {
                        MismoLugarAliadoAmarillo = true;
                        PosicionAmarillo += 5;

                    }

                    break;

                case 4:

                    PosicionVerde += MoverPieza();
                    ColumnaVerde = (PosicionVerde % 10) * 90;
                    FilaVerde = (PosicionVerde / 10) * 90;
                    Caballeros.Left = 55 + ColumnaVerde;
                    Caballeros.Top = 65 + FilaVerde;

                    if (PosicionVerde == PosicionDragonVerde1)
                    {
                        MismoLugarAliadoVerde = true;
                        PosicionVerde += 5;

                    }

                    if (PosicionVerde == PosicionDragonVerde2)
                    {
                        MismoLugarAliadoVerde = true;
                        PosicionVerde += 5;

                    }

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
