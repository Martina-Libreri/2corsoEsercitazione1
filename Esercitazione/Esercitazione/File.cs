using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Esercitazione
{
    public class FileSpese
    {
        //Ho creato quasta classe come prova prima di inserire la classe monitoraggio!

        public static List<string> LetturaFile()
        {
            string path = @"C:\Users\martina.libreri\Desktop\Corso ICubed\2° Corso\Esercitazione 1\Spese.txt";
            //Lettura file
            List<string> st = new List<string>();
            string line;
            int counter = 0; //indica a che linea sono

            using (StreamReader fileReader = File.OpenText(path))
            {
                while ((line = fileReader.ReadLine()) != null)
                {
                    st.Add(line);
                    counter++;
                }

                line = "";
                fileReader.BaseStream.Position = 0; //proprietà

                //Lettura totale file
                line = fileReader.ReadToEnd();

            }
            return st;
        }

        public static void ScritturaFile(List<string> file)
        {
            string path = @"C:\Users\martina.libreri\Desktop\Corso ICubed\2° Corso\Esercitazione 1\spese_elaborate.txt";
            using (StreamWriter writer = File.CreateText(path))
            {
                for(int i=0; i < file.Count; i++)
                {
                    writer.Write(file[i].ToString() + "\n");
                }

            }
        }
    }
}
