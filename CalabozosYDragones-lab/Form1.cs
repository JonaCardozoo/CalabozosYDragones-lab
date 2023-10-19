using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using CalabozosYDragones_lab.Clases;
using System.ComponentModel.Design;
using System.Runtime.Remoting.Messaging;
using System.Collections;
using Microsoft.Win32;

namespace CalabozosYDragones_lab
{
    public partial class Form1 : Form
    {
        Jugador jugadorHumano;
        FHistorial Historial = new FHistorial();
        Intermedio intermedio;
        Caballero caballero;
        Dragones dragones;
        Pieza p;
        Calabozo calabozo;
        Basico basico;
        Experto experto;
        int band = 0;
        bool turnoCaballeroRosado = true;
        bool turnoCaballeroAzul = false;
        bool turnoCaballeroAmarillo = false;
        bool turnoCaballeroVerde = false;
        int partida = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pBdado.Visible = false;
            dado.Visible = true;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Desvisualizacion de paneles
            Calabozo1.Visible = false;
            Calabozo2.Visible = false;
            Calabozo3.Visible = false;
            DragonRosa1.Visible = false;
            DragonRosa2.Visible = false;
            CaballeroAmarillo.Visible = false;
            CaballeroAzul.Visible = false;
            CaballeroRosa.Visible = false;
            CaballeroVerde.Visible = false;
            DragonAmarillo1.Visible = false;
            DragonAmarillo2.Visible = false;
            DragonAzul1.Visible = false;
            DragonAzul2.Visible = false;
            DragonVerde1.Visible = false;
            DragonVerde2.Visible = false;
            CaballeroRosa.Visible = true;
            #endregion
            basico = new Basico(1,2);
            dragones = new Dragones(1);
            intermedio = new Intermedio(1,2);   
            basico.PosicionInicialCaballero(CaballeroRosa);
            basico.PosicionInicialCaballero(CaballeroAzul);
            basico.PosicionInicialCaballero(CaballeroAmarillo);
            basico.PosicionInicialCaballero(CaballeroVerde);

            intermedio.PosicionInicialDragones(DragonRosa1,DragonRosa2);
            intermedio.PosicionInicialDragones(DragonAzul1, DragonAzul2);
            intermedio.PosicionInicialDragones(DragonVerde1, DragonVerde2);
            intermedio.PosicionInicialDragones(DragonAmarillo1, DragonAmarillo2);
            
            //PantallaCarga pantallaCarga = new PantallaCarga(6);
            //pantallaCarga.ShowDialog();

        }

        private void btnJugar_Click_1(object sender, EventArgs e)
        {
            List<Panel> caballeros = new List<Panel> { CaballeroAzul, CaballeroRosa, CaballeroAmarillo, CaballeroVerde};
            List<Panel> dragoness = new List<Panel> { DragonRosa1, DragonRosa2, DragonAzul1, DragonAzul2, DragonAmarillo1, DragonAmarillo2, DragonVerde1, DragonVerde2 };
            int CantidadJugadores = Convert.ToInt32(numericUpDown1.Value);
            Panel dragones_Todos = new Panel();
            int Dificultad = comboBox1.SelectedIndex;
            caballero = new Caballero(1);
            jugadorHumano = new Jugador(textBox1.Text);
            basico = new Basico(1,CantidadJugadores);
            intermedio = new Intermedio(1,CantidadJugadores);
            experto = new Experto(1,CantidadJugadores);
            dragones = new Dragones(1);

            if (comboBox1.SelectedItem != null)
            {
                numericUpDown1.Enabled = false;
                comboBox1.Enabled = false;
               
                if (CantidadJugadores == 1)
                {
                    CaballeroAzul.Visible = true;

                }
                else if (CantidadJugadores == 2)
                {
                    CaballeroAzul.Visible = true;
                    CaballeroAmarillo.Visible = true;

                    
                }
                else if (CantidadJugadores == 3)
                {
                    CaballeroAzul.Visible = true;
                    CaballeroAmarillo.Visible = true;
                    CaballeroVerde.Visible = true;

                }

                if (turnoCaballeroRosado)
                {
                    caballero.TurnoActual = -1;
                    if (Dificultad == 1 || Dificultad == 2)
                    {
                        DragonRosa1.Visible = true;
                        DragonRosa2.Visible = true;
                        dragones.OpcionDragones = 1;
                        dragones.Jugar(DragonRosa1, DragonRosa2);
                    }

                    else if (Dificultad == 0)
                    {
                        DragonRosa1.Visible = false;
                        DragonRosa2.Visible = false;
                    }
                   
                    dado.Visible = false;
                    pBdado.Visible = true;
                    caballero.TurnoCaballero = 1;
                    caballero.Jugar(CaballeroRosa, CaballeroRosa);
                    TimerDado.Stop();
                    TimerDado.Start();
                    dado.Text = caballero.Numero.ToString();

                    if(Dificultad == 1) 
                    {
                        if (caballero.MismoLugarAliadoRosa == true)
                        {
                            listBox1.Items.Add("Aumento 5 lugares el rosa");
                        }
                        if (caballero.MismoLugarEnemigoRosa == true)
                        {
                            listBox1.Items.Add("Retrocede 5 lugares el rosa");
                        }
                    }
                    caballero.TurnoCaballero++;
                    caballero.VerficarGanador();

                    if (caballero.hayGanador)
                    {
                        partida++;
                        foreach (Panel caballeroColor in caballeros)
                                basico.PosicionInicialCaballero(caballeroColor);

                       
                            foreach (Panel DragonesColor in dragoness)
                            {
                                intermedio.PosicionInicialDragones(DragonesColor, dragones_Todos);
                            }

                       
                        WinnerRosa winnerR = new WinnerRosa(4);
                        winnerR.ShowDialog();

                        Historial.listBox1.Items.Add(String.Format("Ganador: {0} de la {1} partida", jugadorHumano,partida));

                        textBox1.Enabled = true;
                        comboBox1.Enabled = true;
                        numericUpDown1.Enabled = true;

                    }
                    listBox1.Items.Add(String.Format("Turno de {0}: " , jugadorHumano , caballero.TurnoActual + " - ROSADO -"));
                    listBox1.Items.Add("El Caballero Rosado se movio: " + caballero.Numero + " Lugares");
                    listBox1.Items.Add("El Dragon Rosado 1 se movio " + dragones.Numero + " Y" + " El Dragon Rosado 2 se movio " + dragones.Numero2 + " Lugares");
                    listBox1.Items.Add("-------------------Jugador Siguiente--------------------------");

                    turnoCaballeroAzul = true;
                    turnoCaballeroRosado = false;

                }

                else if (turnoCaballeroAzul)
                {
                    caballero.TurnoActual = -1;
                    if (Dificultad == 1 || Dificultad == 2)
                    {
                        caballero.dificultad = true;
                        DragonAzul1.Visible = true;
                        DragonAzul2.Visible = true;
                        dragones.OpcionDragones = 2;
                        dragones.Jugar(DragonAzul1, DragonAzul2);
                    }

                    else if (Dificultad == 0)
                    {
                        DragonAzul1.Visible = false;
                        DragonAzul2.Visible = false;
                    }

                    dado.Visible = false;
                    pBdado.Visible = true;
                    caballero.TurnoCaballero = 2;
                    caballero.Jugar(CaballeroAzul,CaballeroAzul);
                    TimerDado.Stop();
                    TimerDado.Start();
                    dado.Text = caballero.Numero.ToString();

                    if(Dificultad == 1)
                    {
                        if (caballero.MismoLugarAliadoAzul == true)
                        {
                            listBox1.Items.Add("Aumento 5 lugares el Azul");
                        }

                        if (caballero.MismoLugarEnemigoAzul == true)
                        {
                            listBox1.Items.Add("Retrocede 5 lugares el Azul");
                        }
                    }
                    
                    caballero.VerficarGanador();
                    if (caballero.hayGanador)
                    {
                        partida++;
                        foreach (Panel caballeroColor in caballeros)
                                basico.PosicionInicialCaballero(caballeroColor);

                        
                            foreach (Panel DragonesColor in dragoness)
                            {
                                intermedio.PosicionInicialDragones(DragonesColor, dragones_Todos);
                            }
                       
                        Historial.listBox1.Items.Add(String.Format("Ganador: Azul de la {0} partida",partida));
                        WinnerAzul winnerA = new WinnerAzul(4);
                        winnerA.ShowDialog();
                        textBox1.Enabled = true;
                        comboBox1.Enabled = true;
                        numericUpDown1.Enabled = true;

                    }
                    listBox1.Items.Add("Turno del Jugador Virtual " + caballero.TurnoActual + " - AZUL -");
                    listBox1.Items.Add("El Caballero Azul se movio: " + caballero.Numero + " Lugares");
                    listBox1.Items.Add("El Dragon Azul 1 se movio " + dragones.Numero + " Y" + " El Dragon Azul 2 se movio " + dragones.Numero2 + " Lugares");
                    listBox1.Items.Add("-------------------Jugador Siguiente--------------------------");

                    if (CantidadJugadores >= 2)
                    {
                        turnoCaballeroAmarillo = true;
                        turnoCaballeroAzul = false;

                    }
                    else
                        turnoCaballeroRosado = true;
                }

                else if (turnoCaballeroAmarillo)
                {
                    caballero.TurnoActual = 0;
                    if (Dificultad == 1 || Dificultad == 2)
                    {
                        caballero.dificultad = true;
                        DragonAmarillo1.Visible = true;
                        DragonAmarillo2.Visible = true;
                        dragones.OpcionDragones = 3;
                        dragones.Jugar(DragonAmarillo1, DragonAmarillo2);
                    }

                    else if (Dificultad == 0)
                    {

                        DragonAmarillo1.Visible = false;
                        DragonAmarillo2.Visible = false;
                    }

                    dado.Visible = false;
                    pBdado.Visible = true;
                    caballero.TurnoCaballero = 3;
                    caballero.Jugar(CaballeroAmarillo, CaballeroAmarillo);
                    TimerDado.Stop();
                    TimerDado.Start();
                    dado.Text = caballero.Numero.ToString();

                    if(Dificultad == 1)
                    {
                        if (caballero.MismoLugarAliadoAmarillo == true)
                        {
                            listBox1.Items.Add("Aumento 5 lugares el Amarillo");
                        }

                        if (caballero.MismoLugarEnemigoAmarillo == true)
                        {
                            listBox1.Items.Add("Retrocede 5 lugares el Amarillo");
                        }


                    }
                    
                    caballero.VerficarGanador();

                    if (caballero.hayGanador)
                    {
                        partida++;
                        foreach (Panel caballeroColor in caballeros)
                                 basico.PosicionInicialCaballero(caballeroColor);

                       
                            foreach (Panel DragonesColor in dragoness)
                            {
                                intermedio.PosicionInicialDragones(DragonesColor, dragones_Todos);
                            }
                       

                        Historial.listBox1.Items.Add(String.Format("Ganador: Amarillo de la {0} partida", partida));

                        WinnerAmarillo winnerAM = new WinnerAmarillo(4);
                        winnerAM.ShowDialog();
                        textBox1.Enabled = true;
                        comboBox1.Enabled = true;
                        numericUpDown1.Enabled = true;

                    }
                    listBox1.Items.Add("Turno del Jugador Virtual  " + caballero.TurnoActual + " - AMARILLO -");
                    listBox1.Items.Add("El Caballero Amarillo se movio: " + caballero.Numero + " Lugares");
                    listBox1.Items.Add("El Dragon Amarillo 1 se movio " + dragones.Numero + " Y" + " El Dragon Amarillo 2 se movio " + dragones.Numero2 + " Lugares");
                    listBox1.Items.Add("-------------------Jugador Siguiente--------------------------");

                    if (CantidadJugadores >= 3)
                    {
                        turnoCaballeroVerde = true;
                        turnoCaballeroAmarillo = false;
                    }

                    else
                        turnoCaballeroRosado = true;
                }
                else if (turnoCaballeroVerde)
                {
                    caballero.TurnoActual = 2;
                    if (Dificultad == 1 || Dificultad == 2)
                    {
                        caballero.dificultad = true;
                        DragonVerde1.Visible = true;
                        DragonVerde2.Visible = true;
                        dragones.OpcionDragones = 4;
                        dragones.Jugar(DragonVerde1, DragonVerde2);
                    }

                    else if (Dificultad == 0)
                    {
                        DragonVerde1.Visible = false;
                        DragonVerde2.Visible = false;
                    }

                    dado.Visible = false;
                    pBdado.Visible = true;
                    caballero.TurnoCaballero = 4;
                    caballero.Jugar(CaballeroVerde, CaballeroVerde);
                    TimerDado.Stop();
                    TimerDado.Start();
                    dado.Text = caballero.Numero.ToString();

                    if(Dificultad == 1)
                    {
                        if (caballero.MismoLugarAliadoVerde == true)
                        {
                            listBox1.Items.Add("Aumenta 5 lugares Verde");
                           
                        }
                        else if (caballero.MismoLugarEnemigoVerde == true)
                        {
                            listBox1.Items.Add("Retrocede 5 lugares Verde");


                        }
                    }
                   
                    caballero.VerficarGanador();

                    if (caballero.hayGanador)
                    {
                        partida++;
                        foreach (Panel caballeroColor in caballeros)
                                basico.PosicionInicialCaballero(caballeroColor);

                        
                            foreach (Panel DragonesColor in dragoness)
                            {
                                intermedio.PosicionInicialDragones(DragonesColor, dragones_Todos);
                            }

                        Historial.listBox1.Items.Add(String.Format("Ganador: Verde de la {0} partida", partida));


                        WinnerVerde winnerV = new WinnerVerde(4);
                        winnerV.ShowDialog();
                        textBox1.Enabled = true;
                        comboBox1.Enabled = true;
                        numericUpDown1.Enabled = true;

                    }
                    listBox1.Items.Add("Turno del Jugador Virtual  " + caballero.TurnoActual + " - VERDE -");
                    listBox1.Items.Add("El Caballero Verde se movio: " + caballero.Numero + " Lugares");
                    listBox1.Items.Add("El Dragon Verde 1 se movio " + dragones.Numero + " Y" + " El Dragon Verde 2 se movio " + dragones.Numero2 + " Lugares");
                    listBox1.Items.Add("-------------------Jugador Siguiente--------------------------");


                    turnoCaballeroRosado = true;
                }
                
                if (Dificultad == 2 && band==0)
                {

                    calabozo = new Calabozo(1);
                    Calabozo1.Left = calabozo.PosLeft();
                    Calabozo1.Top = calabozo.PosTop();
                    Calabozo2.Left = calabozo.PosLeft();
                    Calabozo2.Top = calabozo.PosTop();
                    Calabozo3.Left = calabozo.PosLeft();
                    Calabozo3.Top = calabozo.PosTop();
                    Calabozo1.Visible = true;
                    Calabozo2.Visible = true;
                    Calabozo3.Visible = true;

                }
                
            }
            else
                MessageBox.Show("ERROR, ELIJA MODALIDAD DE JUEGO", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            band = 1;
        }

        #region Metodos Vacios
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DragonAmarillo2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dadoA_VisibleChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {

            List<Panel> caballeros = new List<Panel> { CaballeroAzul, CaballeroRosa, CaballeroAmarillo, CaballeroVerde };
            List<Panel> dragoness = new List<Panel> { DragonRosa1, DragonRosa2, DragonAzul1, DragonAzul2, DragonAmarillo1, DragonAmarillo2, DragonVerde1, DragonVerde2 };
            int CantidadJugadores = Convert.ToInt32(numericUpDown1.Value);
            Panel dragones_Todos = new Panel();
            int Dificultad = comboBox1.SelectedIndex;
            caballero = new Caballero(1);
            jugadorHumano = new Jugador(textBox1.Text);
            basico = new Basico(1, CantidadJugadores);
            intermedio = new Intermedio(1, CantidadJugadores);
            experto = new Experto(1, CantidadJugadores);
            dragones = new Dragones(1);

            if (comboBox1.SelectedItem != null)
            {
                numericUpDown1.Enabled = false;
                comboBox1.Enabled = false;

                if (CantidadJugadores == 1)
                {
                    CaballeroAzul.Visible = true;
                }
                else if (CantidadJugadores == 2)
                {
                    CaballeroAzul.Visible = true;
                    CaballeroAmarillo.Visible = true;
                }
                else if (CantidadJugadores == 3)
                {
                    CaballeroAzul.Visible = true;
                    CaballeroAmarillo.Visible = true;
                    CaballeroVerde.Visible = true;

                }

                if (turnoCaballeroRosado)
                {
                    if (Dificultad == 1 || Dificultad == 2)
                    {
                        DragonRosa1.Visible = true;
                        DragonRosa2.Visible = true;
                        dragones.OpcionDragones = 1;
                        dragones.Jugar(DragonRosa1, DragonRosa2);
                    }

                    else if (Dificultad == 0)
                    {
                        DragonRosa1.Visible = false;
                        DragonRosa2.Visible = false;
                    }

                    dado.Visible = false;
                    pBdado.Visible = true;
                    caballero.TurnoCaballero = 1;
                    caballero.Jugar(CaballeroRosa, CaballeroRosa);
                    TimerDado.Stop();
                    TimerDado.Start();
                    dado.Text = caballero.Numero.ToString();

                    if (Dificultad == 1)
                    {
                        if (caballero.MismoLugarAliadoRosa == true)
                        {
                            listBox1.Items.Add("Aumento 5 lugares el rosa");
                        }
                        if (caballero.MismoLugarEnemigoRosa == true)
                        {
                            listBox1.Items.Add("Retrocede 5 lugares el rosa");
                        }
                    }

                    caballero.VerficarGanador();

                    if (caballero.hayGanador)
                    {
                        foreach (Panel caballeroColor in caballeros)
                            basico.PosicionInicialCaballero(caballeroColor);


                        foreach (Panel DragonesColor in dragoness)
                        {
                            intermedio.PosicionInicialDragones(DragonesColor, dragones_Todos);
                        }

                        

                        WinnerRosa winnerR = new WinnerRosa(4);
                        winnerR.ShowDialog();
                        textBox1.Enabled = true;
                        comboBox1.Enabled = true;
                        numericUpDown1.Enabled = true;

                    }

                    listBox1.Items.Add("El Caballero Rosado se movio: " + caballero.Numero);
                    listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    turnoCaballeroAzul = true;
                    turnoCaballeroRosado = false;

                }

                else if (turnoCaballeroAzul)
                {
                    if (Dificultad == 1 || Dificultad == 2)
                    {
                        caballero.dificultad = true;
                        DragonAzul1.Visible = true;
                        DragonAzul2.Visible = true;
                        dragones.OpcionDragones = 2;
                        dragones.Jugar(DragonAzul1, DragonAzul2);
                    }

                    else if (Dificultad == 0)
                    {
                        DragonAzul1.Visible = false;
                        DragonAzul2.Visible = false;
                    }

                    dado.Visible = false;
                    pBdado.Visible = true;
                    caballero.TurnoCaballero = 2;
                    caballero.Jugar(CaballeroAzul, CaballeroAzul);
                    TimerDado.Stop();
                    TimerDado.Start();
                    dado.Text = caballero.Numero.ToString();

                    if (Dificultad == 1)
                    {
                        if (caballero.MismoLugarAliadoAzul == true)
                        {
                            listBox1.Items.Add("Aumento 5 lugares el Azul");
                        }

                        if (caballero.MismoLugarEnemigoAzul == true)
                        {
                            listBox1.Items.Add("Retrocede 5 lugares el Azul");
                        }
                    }

                    caballero.VerficarGanador();
                    if (caballero.hayGanador)
                    {
                        foreach (Panel caballeroColor in caballeros)
                            basico.PosicionInicialCaballero(caballeroColor);


                        foreach (Panel DragonesColor in dragoness)
                        {
                            intermedio.PosicionInicialDragones(DragonesColor, dragones_Todos);
                        }


                        WinnerAzul winnerA = new WinnerAzul(4);
                        winnerA.ShowDialog();
                        textBox1.Enabled = true;
                        comboBox1.Enabled = true;
                        numericUpDown1.Enabled = true;

                    }
                    listBox1.Items.Add("El Caballero Azul se movio: " + caballero.Numero + " Lugares");
                    listBox1.Items.Add("------------------------------------------------------------------");

                    if (CantidadJugadores >= 2)
                    {

                        turnoCaballeroAmarillo = true;
                        turnoCaballeroAzul = false;

                    }
                    else
                        turnoCaballeroRosado = true;
                }

                else if (turnoCaballeroAmarillo)
                {

                    if (Dificultad == 1 || Dificultad == 2)
                    {
                        caballero.dificultad = true;
                        DragonAmarillo1.Visible = true;
                        DragonAmarillo2.Visible = true;
                        dragones.OpcionDragones = 3;
                        dragones.Jugar(DragonAmarillo1, DragonAmarillo2);
                    }

                    else if (Dificultad == 0)
                    {
                        DragonAmarillo1.Visible = false;
                        DragonAmarillo2.Visible = false;
                    }

                    dado.Visible = false;
                    pBdado.Visible = true;
                    caballero.TurnoCaballero = 3;
                    caballero.Jugar(CaballeroAmarillo, CaballeroAmarillo);
                    TimerDado.Stop();
                    TimerDado.Start();
                    dado.Text = caballero.Numero.ToString();

                    if (Dificultad == 1)
                    {
                        if (caballero.MismoLugarAliadoAmarillo == true)
                        {
                            listBox1.Items.Add("Aumento 5 lugares el Amarillo");
                        }

                        if (caballero.MismoLugarEnemigoAmarillo == true)
                        {
                            listBox1.Items.Add("Retrocede 5 lugares el Amarillo");
                        }


                    }

                    caballero.VerficarGanador();

                    if (caballero.hayGanador)
                    {
                        foreach (Panel caballeroColor in caballeros)
                            basico.PosicionInicialCaballero(caballeroColor);


                        foreach (Panel DragonesColor in dragoness)
                        {
                            intermedio.PosicionInicialDragones(DragonesColor, dragones_Todos);
                        }


                        WinnerAmarillo winnerAM = new WinnerAmarillo(4);
                        winnerAM.ShowDialog();
                        textBox1.Enabled = true;
                        comboBox1.Enabled = true;
                        numericUpDown1.Enabled = true;

                    }

                    listBox1.Items.Add("El Caballero Amarillo se movio: " + caballero.Numero + " Lugares");
                    listBox1.Items.Add("------------------------------------------------------------------");

                    if (CantidadJugadores >= 3)
                    {
                        turnoCaballeroVerde = true;
                        turnoCaballeroAmarillo = false;
                    }

                    else
                        turnoCaballeroRosado = true;
                }
                else if (turnoCaballeroVerde)
                {

                    if (Dificultad == 1 || Dificultad == 2)
                    {
                        caballero.dificultad = true;
                        DragonVerde1.Visible = true;
                        DragonVerde2.Visible = true;
                        dragones.OpcionDragones = 4;
                        dragones.Jugar(DragonVerde1, DragonVerde2);
                    }

                    else if (Dificultad == 0)
                    {
                        DragonVerde1.Visible = false;
                        DragonVerde2.Visible = false;
                    }

                    dado.Visible = false;
                    pBdado.Visible = true;
                    caballero.TurnoCaballero = 4;
                    caballero.Jugar(CaballeroVerde, CaballeroVerde);
                    TimerDado.Stop();
                    TimerDado.Start();
                    dado.Text = caballero.Numero.ToString();

                    if (Dificultad == 1)
                    {
                        if (caballero.MismoLugarAliadoVerde == true)
                        {
                            listBox1.Items.Add("Aumenta 5 lugares Verde");

                        }
                        else if (caballero.MismoLugarEnemigoVerde == true)
                        {
                            listBox1.Items.Add("Retrocede 5 lugares Verde");


                        }
                    }

                    caballero.VerficarGanador();

                    if (caballero.hayGanador)
                    {

                        foreach (Panel caballeroColor in caballeros)
                            basico.PosicionInicialCaballero(caballeroColor);


                        foreach (Panel DragonesColor in dragoness)
                        {
                            intermedio.PosicionInicialDragones(DragonesColor, dragones_Todos);
                        }


                        WinnerVerde winnerV = new WinnerVerde(4);
                        winnerV.ShowDialog();
                        textBox1.Enabled = true;
                        comboBox1.Enabled = true;
                        numericUpDown1.Enabled = true;

                    }

                    listBox1.Items.Add("El Caballero Verde se movio: " + caballero.Numero + " Lugares");
                    listBox1.Items.Add("------------------------------------------------------------------");

                    turnoCaballeroRosado = true;
                }

                if (Dificultad == 2 && band == 0)
                {

                    calabozo = new Calabozo(1);
                    Calabozo1.Left = calabozo.PosLeft();
                    Calabozo1.Top = calabozo.PosTop();
                    Calabozo2.Left = calabozo.PosLeft();
                    Calabozo2.Top = calabozo.PosTop();
                    Calabozo3.Left = calabozo.PosLeft();
                    Calabozo3.Top = calabozo.PosTop();
                    Calabozo1.Visible = true;
                    Calabozo2.Visible = true;
                    Calabozo3.Visible = true;

                }

            }
            else
                MessageBox.Show("ERROR, ELIJA MODALIDAD DE JUEGO", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            band = 1;
        }

        private void btnHistorialPartidas_Click(object sender, EventArgs e)
        {
            Historial.ShowDialog();
        }

    }
    }

