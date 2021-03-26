using Esercitazione.Chain.Entità;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione
{
    class Operazioni
    {
        public static List<string> Get(List<string> testo)
        {
            List<string> letturaFile = new List<string>();
            letturaFile = testo;

            string[] p = null;
            string primaRiga = null;
            List<string> categoria = new List<string>();
            List<string> importo = new List<string>();
            List<string> livelloDiApprovazione = new List<string>();
            List<string> categoriaApprovata = new List<string>();
            List<string> data = new List<string>();
            List<string> descrizione = new List<string>();

            for (int i = 0; i < letturaFile.Count; i++)
            {

                if (i == 0)
                {
                    primaRiga = letturaFile[i];
                }
                else
                {
                    p = letturaFile[i].Split(";");
                    data.Add(p[0]);
                    categoria.Add(p[1]);
                    descrizione.Add(p[2]);
                    importo.Add(p[3]);
                }

            }

            //Gestione approvazione
            var ceo = new CEOHandler();
            var manager = new ManagerHandler();
            var operationalManager = new OperationalManagerHandler();

            //creazione catena handler
            ceo.SetNext(manager).SetNext(operationalManager);
            int count = 0;
            List<string> importoRimborsato = new List<string>();
            List<string> pApp = new List<string>();
            foreach (var i in importo)
            {
                var result = ceo.Handle(i);

                if (result != null)
                {
                    pApp.Add(result);
                    livelloDiApprovazione.Add("APPROVATA");
                    categoriaApprovata.Add(categoria[count]);
                    //Importo rimborsato in base alla categoria
                    int x = Factory.GestioneImporto.GetImporto(categoria[count], i);
                    importoRimborsato.Add(x.ToString());

                }
                else
                {
                    pApp.Add("-");
                    livelloDiApprovazione.Add("RESPINTA");
                    importoRimborsato.Add("-");
                }
                count++;
            }


            List<string> lista = new List<string>();
            lista.Add(primaRiga);
            for (int i = 0; i < livelloDiApprovazione.Count; i++)
            {
                lista.Add($"{data[i]}; {categoria[i]}; {descrizione[i]}; {livelloDiApprovazione[i]}; {pApp[i]}; {importoRimborsato[i]}");
            }


            return lista;


        }
    }
}
