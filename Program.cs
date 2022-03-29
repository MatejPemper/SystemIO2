using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši svoje ime: ");
            string ime= Console.ReadLine();

            string datoteka = "ime.txt";

            if (File.Exists(datoteka))
            {
                if (!Directory.Exists("backup"))
                {
                    Directory.CreateDirectory("backup");
                }

                File.Copy(datoteka, @"backup\ime_" + DateTime.Now.ToString("yyyy_MM__dd__HH__mm__ss") + ".txt");

                File.Delete(datoteka);
            }

            File.WriteAllText(datoteka, ime);


            Console.ReadKey();

        }
    }
}
