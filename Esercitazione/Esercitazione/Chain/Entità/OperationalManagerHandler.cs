using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Chain.Entità
{
    class OperationalManagerHandler : AbstractHandler
    {
        public override string Handle(string request)
        {
            int importo = Convert.ToInt32(request);
            if (importo > 401 && importo<=1000)
            {
                return "Operational Manager";
            }
            else
                return base.Handle(request);
        }
    }
}
