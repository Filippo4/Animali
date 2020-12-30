using System;

namespace Animali
{
    public abstract class Animale : ISalutatore
    {
        public string Nome { get; set; }
        public string Saluta()
        {
            return "l'animale ti sta salutando!";
        }
    }
}
