using Esercitazione.Chain.Entità;
using System;
using System.Collections.Generic;
using System.IO;

namespace Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____WATCHER FILES_____");

            //Creazione FileSystemWatcher -> guardia sul filesystem
            FileSystemWatcher fsw = new FileSystemWatcher();

            //dobbiamo inserire un path ossia dove devo guardare
            //la guardia deve essere posizionata in questo path
            fsw.Path = @"C:\Users\martina.libreri\Desktop\Corso ICubed\2° Corso\Esercitazione 1";

            //deve guardare i file con estensione .txt
            fsw.Filter = "*.txt";

            //Notifica quando succedono questi eventi
            fsw.NotifyFilter = NotifyFilters.LastWrite
                | NotifyFilters.LastAccess
                | NotifyFilters.FileName
                | NotifyFilters.DirectoryName;

            //abilito le notifiche
            fsw.EnableRaisingEvents = true;

            //Multicast delegate -> alla creazione di un file, gestisci con handlenewtextfile
            fsw.Created += Monitoraggio.HandleNewTextFile;


            Console.WriteLine("Press q to exit");
            while (Console.ReadKey().KeyChar != 'q') ;



            //Linee di prova per la classe file

            //List<string> letturaFile = new List<string>();
            //letturaFile = FileSpese.LetturaFile();

            //string[] p = null;
            //string primaRiga = null;
            //List<string> categoria = new List<string>();
            //List<string> importo = new List<string>();
            //List<string> livelloDiApprovazione = new List<string>();
            //List<string> categoriaApprovata = new List<string>();
            //List<string> data = new List<string>();
            //List<string> descrizione = new List<string>();

            //for (int i = 0; i < letturaFile.Count; i++)
            //{

            //    if (i == 0)
            //    {
            //        primaRiga = letturaFile[i];
            //    }
            //    else
            //    {
            //        p = letturaFile[i].Split(";");
            //        data.Add(p[0]);
            //        categoria.Add(p[1]);
            //        descrizione.Add(p[2]);
            //        importo.Add(p[3]);
            //    }

            //}

            ////Gestione approvazione
            //var ceo = new CEOHandler();
            //var manager = new ManagerHandler();
            //var operationalManager = new OperationalManagerHandler();

            ////creazione catena handler
            //ceo.SetNext(manager).SetNext(operationalManager);
            //int count = 0;
            //List<string> importoRimborsato = new List<string>();
            //List<string> pApp = new List<string>();
            //foreach (var i in importo)
            //{
            //    var result = ceo.Handle(i);

            //    if (result != null)
            //    {
            //        pApp.Add(result);
            //        livelloDiApprovazione.Add("APPROVATA");
            //        categoriaApprovata.Add(categoria[count]);
            //        //Importo rimborsato in base alla categoria
            //        int x = Factory.GestioneImporto.GetImporto(categoria[count], i);
            //        importoRimborsato.Add(x.ToString());
                    
            //    }
            //    else
            //    {
            //        pApp.Add("-");
            //        livelloDiApprovazione.Add("RESPINTA");
            //        importoRimborsato.Add("-");
            //    }
            //    count++;
            //}


            //List<string> lista = new List<string>();
            //lista.Add(primaRiga);
            //for (int i = 0; i < livelloDiApprovazione.Count; i++)
            //{
            //    lista.Add($"{data[i]}; {categoria[i]}; {descrizione[i]}; {livelloDiApprovazione[i]}; {pApp[i]}; {importoRimborsato[i]}");
            //}


            //FileSpese.ScritturaFile(lista);


        }
    }
}
