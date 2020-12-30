using System;
using System.Collections.Generic;
using System.Text;

namespace Animali
{
    class PesceVolante : Pesce , IVolante
    {
        public PesceVolante() : base () { }
        public override string Nuota()
        {
            return "il pesce volante sta nuotando!";
        }
        public string Vola()
        {
            return "il pesce volante sta volando!";
        }
    }
}
