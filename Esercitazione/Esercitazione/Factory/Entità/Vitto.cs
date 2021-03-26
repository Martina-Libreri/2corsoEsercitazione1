using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Factory.Entità
{
    class Vitto : ICategory
    {
        public string Nome { get; set; }

        public int Rimborso(int importo)
        {
            return importo* 70/100;
        }
    }
}
