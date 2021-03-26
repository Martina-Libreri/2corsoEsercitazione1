using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Chain.Entità
{
    class ManagerHandler : AbstractHandler
    {
        public override string Handle(string request)
        {
            int importo = Convert.ToInt32(request);
            if (importo <= 400)
            {
                return "Manager";
            }
            else
                return base.Handle(request);
        }
    }
}
