using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalabozosYDragones_lab
{
    internal class Dragones : Pieza
    {
        
        public int Numero {get; set; }
        public int FilaDragonRosa1 { get; set; }
        public int ColumnaDragonRosa1 { get; set; }
        public int FilaDragonRosa2 { get; set; }
        public int ColumnaDragonRosa2 { get; set; }
        public int FilaDragonAzul1 { get; set; }
        public int ColumnaDragonAzul1 { get; set; }
        public int FilaDragonAzul2 { get; set; }
        public int ColumnaDragonAzul2 { get; set; }
        public int FilaDragonAmarillo1 { get; set; }
        public int ColumnaDragonAmarillo1 { get; set; }
        public int FilaDragonAmarillo2 { get; set; }
        public int ColumnaDragonAmarillo2 { get; set; }
        public int FilaDragonVerde1 { get; set; }
        public int ColumnaDragonVerde1 { get; set; }
        public int FilaDragonVerde2 { get; set; }
        public int ColumnaDragonVerde2 { get; set; }

        static Random moverDragones = new Random();
        public Dragones(int posicion): base(posicion) 
        { 
           base.Posicion = posicion;          
        }

        public void PosicionInicialDragones(Panel dragonH1)
        {
            dragonH1.Left = 35;
            dragonH1.Top = 50;

        }

        public override void Jugar(Panel Caballeros, Panel C)
        {
            throw new NotImplementedException();
        }
        public override int MoverPieza()
        {
            throw new NotImplementedException();
        }
    
        public int MoverDragon()
        {
            Numero = moverDragones.Next(1,49);
            return Numero;
        }

        public void MoverDragones(Panel DragonRosa1,Panel DragonRosa2)
        {

            DragonRosa1.Left = 55 + ColumnaDragonRosa1;
            DragonRosa1.Top = 65 + FilaDragonRosa1;
            DragonRosa2.Left = 55 + ColumnaDragonRosa2;
            DragonRosa2.Top = 65 + FilaDragonRosa2;

        }

    }
}
