using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Factory
{
    public interface ICategory
    {
        public string Nome { get; set; }
        int Rimborso(int importo);
    }
}
