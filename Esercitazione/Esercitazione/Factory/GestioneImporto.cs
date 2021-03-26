using Esercitazione.Factory.Entità;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Factory
{
    public class GestioneImporto
    {
        public static int GetImporto(string categoria, string importo)
        {
            int i = Convert.ToInt32(importo);

            ICategory c = null;
            if (categoria.Equals("Alloggio"))
            {
                c = new Alloggio();
                return c.Rimborso(i);
            }
            else if (categoria.Equals("Viaggio"))
            {
                c = new Viaggio();
                return c.Rimborso(i);
            }
            else if (categoria.Equals("Vitto"))
            {
                c = new Vitto();
                return c.Rimborso(i);
            }
            else
            {
                c = new Altro();
                return c.Rimborso(i);
            }
            return 0;  
        }
    }
}
