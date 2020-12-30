using System;
using System.Collections.Generic;
using System.Text;

namespace Animali
{
    class Cigno : Volatile , INuotatore
    {
        public Cigno() : base() { }
        public override string Vola()
        {
            return "il cigno sta volando!";
        }
        public string Nuota()
        {
            return "il cigno sta nuotando";
        }
    }
}
