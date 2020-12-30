using System;
using System.Collections.Generic;
using System.Text;

namespace Animali
{
    class Fattoria
    {
            public List<Animale> Animali { get; private set; }

        public Fattoria() { }
        public void Adotta(Animale animale)
        {
            Animali.Add(animale);
        }
    
    }
}
