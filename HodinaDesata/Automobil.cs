using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HodinaDesata
{
    internal class Automobil : Vozidlo
    {
        public readonly int PocetDveri;
        public readonly string Typ;
        public bool JePojizdne;
        private int _pocetKol;

        public Automobil(int rokVyroby, string barva, string vyrobce, int pocetDveri,string typ) 
            : base(rokVyroby, barva, vyrobce)
        {
            PocetDveri = pocetDveri;
            Typ = typ;
        }

        public override string ToString()
        {
            return $"Automobil: {Vyrobce} {Typ} {RokVyroby}";
        }

        public int PocetKol
        {
            get
            {
                return _pocetKol;
            }
            set
            {
                _pocetKol = value;
                if(value<4)
                {
                    JePojizdne = false;
                }
                else
                {
                    JePojizdne = true;
                }
            }
        }
    }
}
