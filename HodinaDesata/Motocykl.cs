using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HodinaDesata
{
    internal class Motocykl : Vozidlo
    {
        public int PocetKol;
        private int _obsahMotoru;

        public Motocykl(int rokVyroby, string barva, string vyrobce, int pocetKol, int obsahMotoru)
            : base(rokVyroby, barva, vyrobce)
        {
            PocetKol = pocetKol;
            ObsahMotoru = obsahMotoru;
        }

        public override string ToString()
        {
            return $"Motocykl {Vyrobce} potrebny ŘP: {PotrebnyRp}";
        }

        public string Info { 
            get
            {
                return $"Motocykl {Vyrobce}";
            } 
        }
        
        public string PotrebnyRp
        {
            get
            {
                if(ObsahMotoru <=125)
                {
                    return "AM";
                }
                return "A";
            }
        }

        public int ObsahMotoru
        {
            get
            {
                return _obsahMotoru;
            }
            private set
            {
                _obsahMotoru = value;
            }
        }


    }
}
