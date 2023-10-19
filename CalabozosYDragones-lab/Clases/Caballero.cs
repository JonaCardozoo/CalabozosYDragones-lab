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

        public int TurnoActual { get; set; }

        public bool dificultad = false;
        
        public int TurnoCaballero { get; set; }
        static Random Movilizar = new Random();

        public int Turno = 0;

        public int Numero {  get; set; }

        public bool hayGanador = false;
        

        Basico basico;
        Panel caballeroRosa = new Panel();
        public Caballero(int posicion): base(posicion)
        {
            TurnoActual = 0;
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

                    if(dificultad == true)
                    {
                        if (PosicionRosado == PosicionDragonRosa1 || PosicionRosado == PosicionDragonRosa2)
                        {
                            MessageBox.Show("Aumenta 5 lugares ROSA");
                            MismoLugarAliadoRosa = true;
                            PosicionRosado += 5;
                        }

                        else if (PosicionRosado == PosicionDragonAzul1 || PosicionRosado == PosicionDragonAzul2)
                        {
                            MessageBox.Show("Retrocede 5 lugares ROSA");
                            MismoLugarEnemigoRosa = true;
                            PosicionRosado -= 5;

                        }

                        else if (PosicionRosado == PosicionDragonAmarillo1 || PosicionRosado == PosicionDragonAmarillo2)
                        {
                            MessageBox.Show("Retrocede 5 lugares ROSA");
                            MismoLugarEnemigoRosa = true;
                            PosicionRosado -= 5;

                        }

                        else if (PosicionRosado == PosicionDragonVerde1 || PosicionRosado == PosicionDragonVerde2)
                        {
                            MessageBox.Show("Retrocede 5 lugares ROSA");
                            MismoLugarEnemigoRosa = true;
                            PosicionRosado -= 5;

                        }
                    }
                    
                    ColumnaRosado = (PosicionRosado % 10) * 90;
                    FilaRosado = (PosicionRosado / 10) * 90;
                    Caballeros.Left = 55 + ColumnaRosado;
                    Caballeros.Top = 65 + FilaRosado;

                    break;
                case 2:

                    PosicionAzul += MoverPieza();

                    if(dificultad == true)
                    {
                        if (PosicionAzul == PosicionDragonAzul1 || PosicionAzul == PosicionDragonAzul2)
                        {
                            MessageBox.Show("Aumenta 5 lugares AZUL");
                            MismoLugarAliadoAzul = true;
                            PosicionAzul += 5;

                        }

                        else if (PosicionAzul == PosicionDragonRosa1 || PosicionAzul == PosicionDragonRosa2)
                        {
                            MessageBox.Show("retrocede 5 lugares AZUL");
                            MismoLugarEnemigoAzul = true;
                            PosicionAzul -= 5;
                        }

                        else if (PosicionAzul == PosicionDragonAmarillo1 || PosicionAzul == PosicionDragonAmarillo2)
                        {
                            MessageBox.Show("retrocede 5 lugares AZUL");
                            MismoLugarEnemigoAzul = true;
                            PosicionAzul -= 5;
                        }

                        else if (PosicionAzul == PosicionDragonVerde1 || PosicionAzul == PosicionDragonVerde2)
                        {
                            MessageBox.Show("retrocede 5 lugares AZUL");
                            MismoLugarEnemigoAzul = true;
                            PosicionAzul -= 5;
                        }
                    }
                    
                    
                    ColumnaAzul = (PosicionAzul % 10) * 90;
                    FilaAzul = (PosicionAzul / 10) * 90;
                    Caballeros.Left = 55 + ColumnaAzul;
                    Caballeros.Top = 65 + FilaAzul;

                    TurnoActual++;
                    break;

                case 3:

                    PosicionAmarillo += MoverPieza();
                    
                    if(dificultad == true)
                    {
                        if (PosicionAmarillo == PosicionDragonAmarillo1 || PosicionAmarillo == PosicionDragonAmarillo2)
                        {
                            MessageBox.Show("Aumenta 5 lugares Amarillo");
                            MismoLugarAliadoAmarillo = true;
                            PosicionAmarillo += 5;

                        }

                        else if (PosicionAmarillo == PosicionDragonRosa1 || PosicionAmarillo == PosicionDragonRosa2)
                        {
                            MessageBox.Show("Retrocede 5 lugares Amarillo");
                            MismoLugarEnemigoAmarillo = true;
                            PosicionAmarillo -= 5;

                        }

                        else if (PosicionAmarillo == PosicionDragonAzul1 || PosicionAmarillo == PosicionDragonAzul2)
                        {
                            MessageBox.Show("Retrocede 5 lugares Amarillo");
                            MismoLugarEnemigoAmarillo = true;
                            PosicionAmarillo -= 5;

                        }

                        else if (PosicionAmarillo == PosicionDragonVerde1 || PosicionAmarillo == PosicionDragonVerde2)
                        {
                            MessageBox.Show("Retrocede 5 lugares Amarillo");
                            MismoLugarEnemigoAmarillo = true;
                            PosicionAmarillo -= 5;

                        }
                    }
                    

                    ColumnaAmarillo = (PosicionAmarillo % 10) * 90;
                    FilaAmarillo = (PosicionAmarillo / 10) * 90;
                    Caballeros.Left = 55 + ColumnaAmarillo;
                    Caballeros.Top = 65 + FilaAmarillo;
                    TurnoActual++;
                    break;

                case 4:

                    PosicionVerde += MoverPieza();
                    
                    if(dificultad == true)
                    {
                        if (PosicionVerde == PosicionDragonVerde1 || PosicionVerde == PosicionDragonVerde2)
                        {
                            MessageBox.Show("Aumenta 5 lugares Verde");
                            MismoLugarAliadoVerde = true;
                            PosicionVerde += 5;

                        }

                        else if (PosicionVerde == PosicionDragonRosa1 || PosicionVerde == PosicionDragonRosa2)
                        {
                            MessageBox.Show("Retrocede 5 lugares Verde");
                            MismoLugarEnemigoVerde = true;
                            PosicionVerde -= 5;

                        }

                        else if (PosicionVerde == PosicionDragonAzul1 || PosicionVerde == PosicionDragonAzul2)
                        {
                            MessageBox.Show("Retrocede 5 lugares Verde");
                            MismoLugarEnemigoVerde = true;
                            PosicionVerde -= 5;

                        }

                        else if (PosicionVerde == PosicionDragonAmarillo1 || PosicionVerde == PosicionDragonAmarillo2)
                        {
                            MessageBox.Show("Retrocede 5 lugares Verde");
                            MismoLugarEnemigoVerde = true;
                            PosicionVerde -= 5;

                        }
                    }
                    

                    ColumnaVerde = (PosicionVerde % 10) * 90;
                    FilaVerde = (PosicionVerde / 10) * 90;
                    Caballeros.Left = 55 + ColumnaVerde;
                    Caballeros.Top = 65 + FilaVerde;

                    break;

            }
            TurnoActual++;

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
