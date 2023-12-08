using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HodinaDesata
{
    internal class Vozidlo
    {
        public readonly int RokVyroby;
        public string Barva;
        public readonly string Vyrobce;

        public Vozidlo(int rokVyroby, string barva, string vyrobce)
        {
            RokVyroby = rokVyroby;
            Barva = barva;
            Vyrobce = vyrobce;
        }
    }
}
