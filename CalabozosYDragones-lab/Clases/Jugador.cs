using Microsoft.Win32;
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
        int jugador = 0;
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



        //public void Jugar()
        //{
        //    switch (jugador)
        //    {
        //        case 1:
        //            {
                         
        //                caballero.Mover();
                            
        //                if (sistema.HayGanador())
        //                {     
        //                    ganador++;
        //                    
        //                }

        //            }
        //            break;
        //        case 2:
        //            {
        //                
        //                caballero.Mover();
        //                if (sistema.HayGanador())
        //                {
        //                    ganador++;
        //                    
        //                }
        //                break;

        //            }

        //        case 3:
        //            {
        //                CaballeroAmarillo.Left = 55 + columnaAmarillo;
        //                CaballeroAmarillo.Top = 65 + filaAmarillo;
        //                if (posicionC >= 49)
        //                {
        //                    CaballeroAmarillo.Left = 15 + 300;
        //                    CaballeroAmarillo.Top = 38 + 300;
        //                    WinnerAmarillo GanadorAmarillo = new WinnerAmarillo(5);
        //                    GanadorAmarillo.ShowDialog();
        //                    columnaAmarillo = 0;
        //                    filaAmarillo = 0;
        //                    posicionA = 0;
        //                    posicionB = 0;
        //                    posicionC = 0;
        //                    posicionD = 0;
        //                    Iniciar();
        //                    turno = 0;
        //                    Historial.listBox1.Items.Add("Jugador: Maquina 2");
        //                    listBox1.Items.Add("Ganador: " + jugadorHumano);
        //                }

        //                break;
        //            }
        //        case 4:
        //            {
        //                CaballeroVerde.Left = 55 + columnaVerde;
        //                CaballeroVerde.Top = 65 + filaVerde;
        //                if (posicionD >= 49)
        //                {
        //                    CaballeroVerde.Left = 15 + 300;
        //                    CaballeroVerde.Top = 38 + 300;
        //                    WinnerVerde GanadorVerde = new WinnerVerde(5);
        //                    GanadorVerde.ShowDialog();
        //                    columnaVerde = 0;
        //                    filaVerde = 0;
        //                    posicionA = 0;
        //                    posicionB = 0;
        //                    posicionC = 0;
        //                    posicionD = 0;
        //                    Iniciar();
        //                    turno = 0;
        //                    Historial.listBox1.Items.Add("Jugador: Maquina 3");
        //                    listBox1.Items.Add("Ganador: " + jugadorHumano);
        //                }
        //                break;
        //            }
        //    }
        }

    }

