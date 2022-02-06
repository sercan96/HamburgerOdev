using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerOdev
{
    class Icecekler
    {
        public string Adi { get; set; }
        public decimal Fiyati { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}
