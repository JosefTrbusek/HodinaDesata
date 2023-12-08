using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HodinaDesata
{
    internal class SpravceVozidel
    {
        private List<Vozidlo> vozidla;
        public SpravceVozidel()
        {
            vozidla = new List<Vozidlo>();
        }

        public void PridejVozidlo(Vozidlo vozidlo)
        {
            vozidla.Add(vozidlo);
        }

        public void SmazVozidlo(Vozidlo vozidlo)
        {
            vozidla.Remove(vozidlo);
        }

        public Vozidlo VratVozidlo(int index)
        {
            return vozidla[index];
        }

        public int VratPocetVozidel()
        {
            return vozidla.Count;
        }
    }
}
