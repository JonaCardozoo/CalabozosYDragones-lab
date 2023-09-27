using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab.Clases
{
    internal class Calabozo
    {
    
        public int Cala { get; set; }
        Random random = new Random();

        public Calabozo(int posicion)
        {
            Cala = posicion;
        }


        public int PosicionEstaticaCalabozo()
        {
            int ObtenerNumero = random.Next(1, 49);
            return ObtenerNumero;
        }


        //public void PosicionCala(Panel Calabozo)
        //{
        //    int pos = random.Next(1, 49);
        //    Calabozo.Left = 55 + ((pos % 10) * 90);
        //    Calabozo.Top = 70 + ((pos / 10) * 90);
        //    pos = random.Next(1, 49);

        //    Calabozo.Left = 47 + ((pos % 10) * 90);
        //    Calabozo.Top = 55 + ((pos / 10) * 90);
        //}

        public void PosicionInicialCala(Panel Calabozo)
        {
            Calabozo.Left = 35;
            Calabozo.Top = 50;
        }
        

    }
}


    

