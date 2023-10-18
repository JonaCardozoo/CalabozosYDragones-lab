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

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Panel> caballeros = new List<Panel> { CaballeroAzul, CaballeroRosa, CaballeroAmarillo, CaballeroVerde};
            List<Panel> dragoness = new List<Panel> { DragonRosa1, DragonRosa2, DragonAzul1, DragonAzul2, DragonAmarillo1, DragonAmarillo2, DragonVerde1, DragonVerde2 };
            int CantidadJugadores = Convert.ToInt32(numericUpDown1.Value);

            int Dificultad = comboBox1.SelectedIndex;
            

            caballero = new Caballero(1);
            jugadorHumano = new Jugador(textBox1.Text);
            basico = new Basico(1,CantidadJugadores);
            intermedio = new Intermedio(1,CantidadJugadores);
            experto = new Experto(1,CantidadJugadores);
            dragones = new Dragones(1);
            if (comboBox1.SelectedItem != null)
            {
                if(Dificultad == 1)
                {
                    DragonRosa1.Visible = true;
                    DragonRosa2.Visible = true;
                }
                numericUpDown1.Enabled = false;
                comboBox1.Enabled = false;
               
                if (CantidadJugadores == 1)
                {
                    CaballeroAzul.Visible = true;
                    if (comboBox1.SelectedIndex == 1)
                    {
                        DragonAzul1.Visible = true;
                        DragonAzul2.Visible = true;
                    }

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
                    if (Dificultad == 1)
                    {
                        dragones.OpcionDragones = 1;
                        dragones.Jugar(DragonRosa1, DragonRosa2);
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
                            MessageBox.Show("Mueve 5 lugares Rosa");
                        }
                        if (caballero.MismoLugarEnemigoRosa == true)
                        {
                            MessageBox.Show("Retrocede 5 lugares Rosa");
                        }
                    }
                    
                    caballero.VerficarGanador();
                    if (caballero.hayGanador)
                    {
                        foreach (Panel caballeroColor in caballeros)
                                basico.PosicionInicialCaballero(caballeroColor);
                        WinnerRosa winnerR = new WinnerRosa(4);
                        winnerR.ShowDialog();
                    }

                    listBox1.Items.Add("El Caballero Rosado se movio: " + caballero.Numero);
                    turnoCaballeroAzul = true;
                    turnoCaballeroRosado = false;

                }

                else if (turnoCaballeroAzul)
                {
                    if (Dificultad == 1)
                    {
                        dragones.OpcionDragones = 2;
                        dragones.Jugar(DragonAzul1, DragonAzul2);
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
                            MessageBox.Show("Mueve 5 lugares Azul");
                        }

                        if (caballero.MismoLugarEnemigoAzul == true)
                        {
                            MessageBox.Show("Retrocede 5 lugares Azul");
                        }
                    }
                    

                    caballero.VerficarGanador();
                    if (caballero.hayGanador)
                    {
                        foreach (Panel caballeroColor in caballeros)
                                basico.PosicionInicialCaballero(caballeroColor);

                        WinnerAzul winnerA = new WinnerAzul(4);
                        winnerA.ShowDialog();

                    }
                        listBox1.Items.Add("El Caballero Azul se movio: " + caballero.Numero + " Lugares");

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
                            MessageBox.Show("Mueve 5 lugares Amarillo");
                        }
                    }
                    
                    caballero.VerficarGanador();

                    if (caballero.hayGanador)
                    {
                        foreach (Panel caballeroColor in caballeros)
                                 basico.PosicionInicialCaballero(caballeroColor);

                        WinnerAmarillo winnerAM = new WinnerAmarillo(4);
                        winnerAM.ShowDialog();

                    }
                        listBox1.Items.Add("El Caballero Amarillo se movio: " + caballero.Numero + " Lugares");

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
                            MessageBox.Show("Mueve 5 lugares Verde");
                        }
                    }
                   
                    caballero.VerficarGanador();

                    if (caballero.hayGanador)
                    {
                        
                        foreach (Panel caballeroColor in caballeros)
                                basico.PosicionInicialCaballero(caballeroColor);


                        WinnerVerde winnerV = new WinnerVerde(4);
                        winnerV.ShowDialog();

                    }

                    listBox1.Items.Add("El Caballero Verde se movio: " + caballero.Numero + " Lugares");
                    turnoCaballeroRosado = true;
                }
                
                if (Dificultad == 2 && band==0)
                {

                    calabozo = new Calabozo(1);
                    Calabozo1.Left = calabozo.PosLeft();
                    Calabozo1.Top = calabozo.PosTop();
                    Calabozo2.Left =calabozo.PosLeft();
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
            
        }

        private void btnHistorialPartidas_Click(object sender, EventArgs e)
        {
            Historial.ShowDialog();
        }

    }
    }

