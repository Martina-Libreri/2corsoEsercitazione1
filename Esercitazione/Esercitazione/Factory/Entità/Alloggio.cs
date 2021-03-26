using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Factory.Entità
{
    class Alloggio : ICategory
    {
        public string Nome { get; set; }

        public int Rimborso(int importo)
        {
            return importo;
        }
    }
}
