using System;
using System.Collections.Generic;
using System.Text;

namespace Animali
{
    public class Squalo : Pesce
    {
       public Squalo() : base() {}
        public override string Nuota()
        {
            return "lo squalo nuota!";
        }
    }
}
