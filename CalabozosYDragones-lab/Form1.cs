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
        Caballero caballero2;
        Dragones dragones;
        Pieza p;
        Calabozo calabozo;
        Basico basico;
        Experto experto;

        int turno = 0;
        int posicionA = 0;
        int posicionB = 0;
        int posicionC = 0;
        int posicionD = 0;
        int jugador = 0;
        

        public Form1()
        {
            InitializeComponent();

            Sistema sis = new Sistema();
            //SoundPlayer soundPlayer = new SoundPlayer();
            //soundPlayer.SoundLocation = "C:/Users/Administrator/Desktop/Musica/AgeOfEmpire.wav";
            //soundPlayer.Play();

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
            caballero = new Caballero(1);
            caballero.PosicionInicialCaballero(CaballeroRosa);
            caballero.PosicionInicialCaballero(CaballeroAzul);
            //PantallaCarga pantallaCarga = new PantallaCarga(3);
            //pantallaCarga.ShowDialog();
        }

        private void dragoncito_Tick(object sender, EventArgs e)
        {

        }

        private void DragoncitoHumano2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DragoncitoHumano1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CaballeroAzul_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CaballeroRojo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            bool turnoCaballeroRosado = true;
            bool turnoCaballeroAzul = false;
            bool turnoCaballeroAmarillo = false;
            bool turnoCaballeroVerde = false;
            int CantidadJugadores = Convert.ToInt32(numericUpDown1.Value);
            caballero = new Caballero(1);
            caballero2 = new Caballero(1);
            jugadorHumano = new Jugador(textBox1.Text);
            basico = new Basico(1,CantidadJugadores);
            intermedio = new Intermedio(1,CantidadJugadores);
            experto = new Experto(1,CantidadJugadores);
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
                    dado.Visible = false;
                    pBdado.Visible = true;
                    caballero.TurnoCaballero = 1;
                    caballero.Jugar(CaballeroRosa,CaballeroRosa);
                    TimerDado.Stop();
                    TimerDado.Start();
                    dado.Text = caballero.Numero.ToString();
                    listBox1.Items.Add("El Caballero Rosado se movio: " + caballero.Numero);
                    turnoCaballeroRosado = false;
                    turnoCaballeroAzul = true;
                }

                if (turnoCaballeroAzul)
                {

                    dado.Visible = false;
                    pBdado.Visible = true;
                    caballero2.TurnoCaballero = 2;
                    caballero2.Jugar(CaballeroAzul,CaballeroAzul);
                    TimerDado.Stop();
                    TimerDado.Start();
                    dado.Text = caballero2.Numero.ToString();
                    listBox1.Items.Add("El Caballero Azul se movio: " + caballero2.Numero + " Lugares");

                    if (CantidadJugadores >= 2)
                    {
                        turnoCaballeroAzul = false;
                        turnoCaballeroAmarillo = true;
                    }
                    else
                        turnoCaballeroRosado = true; 
                }
                else if (turnoCaballeroAmarillo)
                {
                    //dado.Visible = false;
                    //jugador = 3;
                    //pBdado.Visible = true;
                    //TimerDado.Stop();
                    //TimerDado.Start();
                    //posicionC += basico.Mover();
                    //columnaAmarillo = (posicionC % 10) * 90;
                    //filaAmarillo = (posicionC / 10) * 90;
                    //dado.Text = basico.Numero.ToString();
                    //listBox1.Items.Add("El Caballero Amarillo se movio: " + basico.Numero);

                    if (CantidadJugadores >= 3)
                    {
                        turnoCaballeroAmarillo = false;
                        turnoCaballeroVerde = true;
                    }

                    else
                        turnoCaballeroRosado = true;
                }
                else if (turnoCaballeroVerde)
                {
                    //dado.Visible = false;
                    //jugador = 4;
                    //pBdado.Visible = true;
                    //TimerDado.Stop();
                    //TimerDado.Start();
                    //posicionD += basico.Mover();
                    //columnaVerde = (posicionD % 10) * 90;
                    //filaVerde = (posicionD / 10) * 90;
                    //dado.Text = basico.Numero.ToString();
                    //listBox1.Items.Add("El Caballero Verde se movio: " + basico.Numero);

                    turnoCaballeroRosado = true;
                }
                
                if (comboBox1.SelectedIndex == 2)
                    {

                    //posicionCalabozo1 = calabozo.PosicionEstaticaCalabozo();
                    //Calabozo1.Left = 55 + ((posicionCalabozo1 % 10) * 90);
                    //Calabozo1.Top = 70 + ((posicionCalabozo1 / 10) * 90);



                    //posicionCalabozo2 = calabozo.PosicionEstaticaCalabozo();
                    //Calabozo2.Left = 55 + ((posicionCalabozo2 % 10) * 90);
                    //Calabozo2.Top = 70 + ((posicionCalabozo2 / 10) * 90);



                    //posicionCalabozo3 = calabozo.PosicionEstaticaCalabozo();
                    //Calabozo3.Left = 55 + ((posicionCalabozo3 % 10) * 90);
                    //Calabozo3.Top = 70 + ((posicionCalabozo3 / 10) * 90);

                    

                    //Calabozo1.Visible = true;
                    //Calabozo2.Visible = true;
                    //Calabozo3.Visible = true;

                    }
                

            }
            else
                MessageBox.Show("ERROR, ELIJA MODALIDAD DE JUEGO", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            {

            }

            private void DragonAmarillo2_Paint(object sender, PaintEventArgs e)
            {

            }

            private void pictureBox1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem!= null)
            {
                while (posicionA<=49 && posicionB <=49 && posicionC<=49 && posicionD<=49)
                {
                        jugadorHumano = new Jugador(textBox1.Text);
                        
                        //intermedio = new Intermedio(dragones.Posicion, Convert.ToInt32(numericUpDown1.Value));
                        numericUpDown1.Enabled = false;
                        comboBox1.Enabled = false;

                        decimal numeros = numericUpDown1.Value;

                        if (numeros == 1)
                        {
                            CaballeroAzul.Visible = true;
                            
                        }
                        else if (numeros == 2)
                        {
                            CaballeroAzul.Visible = true;
                            CaballeroAmarillo.Visible = true;
                        }
                        else if (numeros == 3)
                        {
                            CaballeroAzul.Visible = true;
                            CaballeroAmarillo.Visible = true;
                            CaballeroVerde.Visible = true;
                        }

                        if (comboBox1.SelectedIndex == 1)
                        {

                            #region DragoRosa1
                            int DragonHumano = 0;
                            DragonHumano = dragones.MoverDragon();
                            dragones.ColumnaDragonRosa1 = (DragonHumano % 10) * 90;
                            dragones.FilaDragonRosa1 = (DragonHumano / 10) * 90;

                            #endregion

                            #region DragonRosa2
                            int DragonHumano2 = 0;
                            DragonHumano2 = dragones.MoverDragon();
                            dragones.ColumnaDragonRosa2 = (DragonHumano2 % 10) * 90;
                            dragones.FilaDragonRosa2 = (DragonHumano2 / 10) * 90;
                            #endregion

                            #region DragonVerde1

                            #endregion

                            #region DragonVerde2

                            #endregion

                            #region DragonAmarillo1

                            #endregion

                            #region DragonAmarillo2

                            #endregion

                            #region DragonAzul1

                            #endregion

                            #region DragonAzul2

                            #endregion

                        }
                    int cont = 0;

                        if (comboBox1.SelectedIndex == 2 && cont == 0)
                        {
                            
                            //calabozo.PosicionCala(Calabozo1);
                            //calabozo.PosicionCala(Calabozo2);
                            //calabozo.PosicionCala(Calabozo3);
                            //Calabozo2.Visible = true;
                            //Calabozo1.Visible = true;
                            //Calabozo3.Visible = true;

                        }
                        
                        cont = 1;

                    if (turno == 0)
                    {

                        //dado.Visible = false;
                        //jugador = 1;
                        //pBdado.Visible = true;
                        //TimerDado.Stop();
                        //TimerDado.Start();
                        //posicionA += basico.Mover();
                        //columnaRosado = (posicionA % 10) * 90;
                        //filaRosado = (posicionA / 10) * 90;
                        //dado.Text = basico.Numero.ToString();
                        //listBox1.Items.Add("El Caballero Rosado se movio: " + basico.Numero);

                        turno = 1;
                    }
                    else if (turno == 1)
                    {

                        //dado.Visible = false;
                        //jugador = 2;
                        //pBdado.Visible = true;
                        //TimerDado.Stop();
                        //TimerDado.Start();
                        //posicionB += basico.Mover();
                        //columnaAzul = (posicionB % 10) * 90;
                        //filaAzul = (posicionB / 10) * 90;
                        //dado.Text = basico.Numero.ToString();
                        //listBox1.Items.Add("El Caballero Azul se movio: " + basico.Numero);

                        if (numeros >= 2)
                            turno = 2;
                        else
                            turno = 0;
                    }
                    else if (turno == 2)
                    {
                        //dado.Visible = false;
                        //jugador = 3;
                        //pBdado.Visible = true;
                        //TimerDado.Stop();
                        //TimerDado.Start();
                        //posicionC += basico.Mover();
                        //columnaAmarillo = (posicionC % 10) * 90;
                        //filaAmarillo = (posicionC / 10) * 90;
                        //dado.Text = basico.Numero.ToString();
                        //listBox1.Items.Add("El Caballero Amarillo se movio: " + basico.Numero);

                        if (numeros >= 3)
                            turno = 3;

                        else
                            turno = 0;
                    }
                    else if (turno == 3)
                    {
                        //dado.Visible = false;
                        //jugador = 4;
                        //pBdado.Visible = true;
                        //TimerDado.Stop();
                        //TimerDado.Start();
                        //posicionD += basico.Mover();
                        //columnaVerde = (posicionD % 10) * 90;
                        //filaVerde = (posicionD / 10) * 90;
                        //dado.Text = basico.Numero.ToString();
                        //listBox1.Items.Add("El Caballero Verde se movio: " + basico.Numero);

                        turno = 0;
                    }

                }

                }
            
            else
                MessageBox.Show("ERROR, ELIJA MODALIDAD DE JUEGO", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnHistorialPartidas_Click(object sender, EventArgs e)
        {
            
            Historial.ShowDialog();

        }
    }
    }

