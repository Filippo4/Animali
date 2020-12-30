using System;
using System.Collections.Generic;
using System.Text;

namespace Animali
{
    public abstract class Pesce : Animale, INuotatore
    {
        public abstract string Nuota();
    }
}
