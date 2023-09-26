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
<<<<<<< HEAD
    {
=======
    { 
>>>>>>> b8aa058a83a0992f96d9e98ca214624ef190129f
        public Panel Cala { get; set; }
        Random random = new Random();
        public void PosicionCala(Panel Calabozo)
        {
<<<<<<< HEAD
            int pos = random.Next(1, 49);
            Calabozo.Left = 55 + ((pos % 10) * 90);
            Calabozo.Top = 70 + ((pos / 10) * 90);
=======
            int pos = random.Next(1,49);
            Calabozo.Left = 47 +((pos % 10) * 90);
            Calabozo.Top = 55 + ((pos / 10) * 90);
>>>>>>> b8aa058a83a0992f96d9e98ca214624ef190129f
        }
        public void PosicionInicialCala(Panel Calabozo)
        {
            Calabozo.Left = 35;
            Calabozo.Top = 50;
        }
        public Calabozo(Panel posicion)
        {
            Cala = posicion;
        }
<<<<<<< HEAD

=======
        
>>>>>>> b8aa058a83a0992f96d9e98ca214624ef190129f

    }
}
