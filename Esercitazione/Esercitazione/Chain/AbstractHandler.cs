using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Chain
{
    abstract class AbstractHandler : IHandler
    {
        private IHandler NextHandler;
        public virtual string Handle(string request)
        {
            if (this.NextHandler != null)
            {
                return this.NextHandler.Handle(request);
            }
            else
                return null;
        }

        public IHandler SetNext(IHandler handler)
        {
            NextHandler = handler;
            return handler;
        }
    }
}
