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


namespace CalabozosYDragones_lab
{
    public partial class Form1 : Form
    {
        static Panel Hola { get; set; }

        Sistema sistema = new Sistema();
        Intermedio intermedio;

        Caballero caballero = new Caballero(Hola);
        Dragones dragones = new Dragones(Hola);
        Dragones dragones2 = new Dragones(Hola);
        Experto experto;
        Calabozo calabozo = new Calabozo(Hola);


        Pieza pieza;
        int a = 0;
        int columnaRosado = 0;
        int filaRosado = 0;
        int columnaAmarillo = 0;
        int filaAmarillo = 0;
        int columnaAzul = 0;
        int filaAzul = 0;
        int columnaVerde = 0;
        int filaVerde = 0;
        int cont = 0;


        int posicionA = 0;
        int posicionB = 0;
        int posicionC = 0;
        int posicionD = 0;
        int jugador = 0;
        int posicionDragon = 0;
        int columna = 0;
        int fila = 0;
        int posiciondragon2 = 0;
        int columnaDragon2 = 0;
        int filaDragon2 = 0;
        int columnaDragon1 = 0;
        int filaDragon1 = 0;
        int turno = 0;


        public Form1()
        {
            InitializeComponent();
            Sistema sis = new Sistema();
            Iniciar();
            //SoundPlayer soundPlayer = new SoundPlayer();
            //soundPlayer.SoundLocation = "C:/Users/Administrator/Desktop/Musica/AgeOfEmpire.wav";
            //soundPlayer.Play();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pBdado.Visible = false;
            dado.Visible = true;
        }

        private void Iniciar()
        {
            caballero.PosicionInicialCaballero(CaballeroRosa);
            caballero.PosicionInicialCaballero(CaballeroAzul);
            caballero.PosicionInicialCaballero(CaballeroAmarillo);
            caballero.PosicionInicialCaballero(CaballeroVerde);
            Refresh();

            //dragones.PosicionInicialDH(DragoncitoHumano1);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
            if (comboBox1.SelectedItem != null)
            {
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

                if (comboBox1.SelectedIndex == 2 && cont == 0)
                {
                    if (comboBox1.SelectedIndex == 2 && cont == 0)
                    {


                        calabozo.PosicionCala(Calabozo1);
                        calabozo.PosicionCala(Calabozo2);
                        calabozo.PosicionCala(Calabozo3);
                        Calabozo2.Visible = true;
                        Calabozo1.Visible = true;
                        Calabozo3.Visible = true;

                    }
                    cont = 1;

                    if (turno == 0)
                    {


                        calabozo.PosicionCala(Calabozo1);
                        calabozo.PosicionCala(Calabozo2);
                        calabozo.PosicionCala(Calabozo3);
                        Calabozo2.Visible = true;
                        Calabozo1.Visible = true;
                        Calabozo3.Visible = true;

                    }
                    cont = 1;

                    if (turno == 0)
                    {

                        dado.Visible = false;
                        jugador = 1;
                        pBdado.Visible = true;
                        TimerDado.Stop();
                        TimerDado.Start();
                        posicionA += caballero.Mover();
                        columnaRosado = (posicionA % 10) * 90;
                        filaRosado = (posicionA / 10) * 90;
                        dado.Text = caballero.Numero.ToString();
                        listBox1.Items.Add("El Caballero Rosado se movio: " + caballero.Numero);

                        turno = 1;
                    }
                    else if (turno == 1)
                    {

                        dado.Visible = false;
                        jugador = 2;
                        pBdado.Visible = true;
                        TimerDado.Stop();
                        TimerDado.Start();
                        posicionB += caballero.Mover();
                        columnaAzul = (posicionB % 10) * 90;
                        filaAzul = (posicionB / 10) * 90;
                        dado.Text = caballero.Numero.ToString();
                        listBox1.Items.Add("El Caballero Azul se movio: " + caballero.Numero);
                        if (numeros >= 2)
                            turno = 2;
                        else
                            turno = 0;
                    }
                    else if (turno == 2)
                    {
                        dado.Visible = false;
                        jugador = 3;
                        pBdado.Visible = true;
                        TimerDado.Stop();
                        TimerDado.Start();
                        posicionC += caballero.Mover();
                        columnaAmarillo = (posicionC % 10) * 90;
                        filaAmarillo = (posicionC / 10) * 90;
                        dado.Text = caballero.Numero.ToString();
                        listBox1.Items.Add("El Caballero Amarillo se movio: " + caballero.Numero);

                        if (numeros >= 3)
                            turno = 3;

                        else
                            turno = 0;
                    }
                    else if (turno == 3)
                    {
                        dado.Visible = false;
                        jugador = 4;
                        pBdado.Visible = true;
                        TimerDado.Stop();
                        TimerDado.Start();
                        posicionD += caballero.Mover();
                        columnaVerde = (posicionD % 10) * 90;
                        filaVerde = (posicionD / 10) * 90;
                        dado.Text = caballero.Numero.ToString();
                        listBox1.Items.Add("El Caballero Verde se movio: " + caballero.Numero);

                        turno = 0;
                    }
                }
                else
                    MessageBox.Show("ERROR, ELIJA MODALIDAD DE JUEGO", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

                if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2)
                {
                    dragones = new Dragones(DragonRosa1);
                    dragones = new Dragones(DragonRosa2);
                    dragones = new Dragones(DragonAzul1);
                    dragones = new Dragones(DragonAzul2);
                    dragones.PosicionInicialDragones(DragonRosa1);
                    dragones.PosicionInicialDragones(DragonRosa2);
                    dragones.PosicionInicialDragones(DragonAzul1);
                    dragones.PosicionInicialDragones(DragonAzul2);
                    dragones.PosicionInicialDragones(DragonAmarillo1);
                    dragones.PosicionInicialDragones(DragonAmarillo2);
                    dragones.PosicionInicialDragones(DragonAmarillo1);
                    dragones.PosicionInicialDragones(DragonAmarillo2);
                    dragones.PosicionInicialDragones(DragonVerde1);
                    dragones.PosicionInicialDragones(DragonVerde2);

                    DragonRosa1.Visible = true;
                    DragonRosa2.Visible = true;
                    DragonVerde1.Visible = true;
                    DragonVerde2.Visible = true;
                    DragonAmarillo1.Visible = true;
                    DragonAmarillo2.Visible = true;
                    DragonAzul1.Visible = true;
                    DragonAzul2.Visible = true;

                }
                if (comboBox1.SelectedIndex == 2)
                {
                    calabozo.PosicionInicialCala(Calabozo1);
                    calabozo.PosicionInicialCala(Calabozo2);
                    calabozo.PosicionInicialCala(Calabozo3);
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    calabozo.PosicionInicialCala(Calabozo1);
                    calabozo.PosicionInicialCala(Calabozo2);
                    calabozo.PosicionInicialCala(Calabozo3);
                }

                else
                {
                    DragonRosa1.Visible = false;
                    DragonRosa2.Visible = false;
                    DragonVerde1.Visible = false;
                    DragonVerde2.Visible = false;
                    DragonAmarillo1.Visible = false;
                    DragonAmarillo2.Visible = false;
                    DragonAzul1.Visible = false;
                    DragonAzul2.Visible = false;
                }

            }

            private void dadoA_VisibleChanged(object sender, EventArgs e)
            {
                switch (jugador)
                {
                    case 1:
                        {

                            DragonRosa1.Left = 55 + dragones.ColumnaDragonRosa1;
                            DragonRosa1.Top = 65 + dragones.FilaDragonRosa1;
                            DragonRosa2.Left = 55 + dragones.ColumnaDragonRosa2;
                            DragonRosa2.Top = 65 + dragones.FilaDragonRosa2;
                            CaballeroRosa.Left = 55 + columnaRosado;
                            CaballeroRosa.Top = 65 + filaRosado;

                            if (posicionA >= 49)
                            {
                                CaballeroRosa.Left = 15 + 300;
                                CaballeroRosa.Top = 5 + 300;
                                MessageBox.Show("GANO EL CABALLERO ROSA");
                                columnaRosado = 0;
                                filaRosado = 0;
                                posicionA = 0;
                                posicionB = 0;
                                posicionC = 0;
                                posicionD = 0;
                                Iniciar();
                                turno = 0;
                            }

                        }
                        break;
                    case 2:
                        {
                            CaballeroAzul.Left = 55 + columnaAzul;
                            CaballeroAzul.Top = 65 + filaAzul;
                            if (posicionB >= 49)
                            {
                                CaballeroAzul.Left = 15 + 300;
                                CaballeroAzul.Top = 38 + 300;
                                MessageBox.Show("GANO EL CABALLERO AZUL");
                                columnaAzul = 0;
                                filaAzul = 0;
                                posicionA = 0;
                                posicionB = 0;
                                posicionC = 0;
                                posicionD = 0;
                                Iniciar();
                                turno = 0;
                            }
                            break;


                        }

                    case 3:
                        {
                            CaballeroAmarillo.Left = 55 + columnaAmarillo;
                            CaballeroAmarillo.Top = 65 + filaAmarillo;
                            if (posicionC >= 49)
                            {
                                CaballeroAmarillo.Left = 15 + 300;
                                CaballeroAmarillo.Top = 38 + 300;
                                MessageBox.Show("GANO EL CABALLERO AMARILLO");
                                columnaAmarillo = 0;
                                filaAmarillo = 0;
                                posicionA = 0;
                                posicionB = 0;
                                posicionC = 0;
                                posicionD = 0;
                                Iniciar();
                                turno = 0;
                            }

                            break;
                        }
                    case 4:
                        {
                            CaballeroVerde.Left = 55 + columnaVerde;
                            CaballeroVerde.Top = 65 + filaVerde;
                            if (posicionD >= 49)
                            {
                                CaballeroVerde.Left = 15 + 300;
                                CaballeroVerde.Top = 38 + 300;
                                MessageBox.Show("GANO EL CABALLERO VERDE");
                                columnaVerde = 0;
                                filaVerde = 0;
                                posicionA = 0;
                                posicionB = 0;
                                posicionC = 0;
                                posicionD = 0;
                                Iniciar();
                                turno = 0;
                            }
                            break;
                        }
                }
            }

            private void pictureBox1_Click_1(object sender, EventArgs e)
            {

            }
        }
    }

