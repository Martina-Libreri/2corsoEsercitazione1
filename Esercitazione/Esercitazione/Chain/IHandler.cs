using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Chain
{
    interface IHandler
    {
        //Metodi
        //uno per settare la catena
        IHandler SetNext(IHandler handler);
        //uno per rispondere
        string Handle(string request);

    }
}
