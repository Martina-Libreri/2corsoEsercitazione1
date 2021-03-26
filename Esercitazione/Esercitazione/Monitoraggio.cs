using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Esercitazione
{
    //la classe la definisco statica perchè non devo effettuare istanze della classe
    public static class Monitoraggio
    {
        public static void HandleNewTextFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"__A new file has been created : {e.Name}__");
            List<string> st = new List<string>();
            //Lettura del file
            //creo un oggetto che mi gestisca il flusso di caratteri del testo, opentext vuole in ingresso il path che il reader vuole aprire
            using (StreamReader reader = File.OpenText(e.FullPath))
            {
                
                int counter = 0; //indica a che linea sono

                Thread.Sleep(1000);
                
                Console.WriteLine($"### {e.Name } Content ###");
                //quello che leggiamo lo mettiamo nella stringa
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //scrivo a console quello che leggiamo dal file
                    Console.WriteLine(line);
                    st.Add(line);
                    counter++;
                }
                Console.WriteLine("### End Content ###");
                Console.WriteLine();
                reader.Close();
                
            }
            List<string> lista = new List<string>();
            lista = Operazioni.Get(st);
            //scrittura su un altro file che è stato letto 
            //creiamo il file e ogi volta lo andiamo a sovrascrivere
            using (StreamWriter writer = File.CreateText(@"C:\Users\Martina.libreri\Desktop\Corso ICubed\2° Corso\Esercitazione 1\Spese_elaborate.txt"))
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    writer.Write(lista[i].ToString() + "\n");
                }
                writer.Close();
            }
        }

    }
}
