using System;
using System.Collections.Generic;
using System.Text;

namespace Animali
{
    class Aquila : Volatile
    {
        public Aquila() : base() { }
        public override string Vola()
        {
            return "l'aquila sta volando!";
        }
    }
}
