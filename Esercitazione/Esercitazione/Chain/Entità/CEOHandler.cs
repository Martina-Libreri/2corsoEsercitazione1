using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Chain.Entità
{
    class CEOHandler : AbstractHandler
    {
        public override string Handle(string request)
        {
            int importo = Convert.ToInt32(request);
            if (importo > 1000 && importo < 2500)
            {
                return "CEO";
            }
            else
                return base.Handle(request);
        }
    }
}
