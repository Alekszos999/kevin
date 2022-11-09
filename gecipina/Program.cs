using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace gecipina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> adatok = new List<string>();

            //StreamReader be = new StreamReader("magyar_szavak.txt");

            //while (!be.EndOfStream)
            //{
            //    adatok.Add(be.ReadLine());
            //}

            //Console.WriteLine(adatok.Count);

            //Console.WriteLine();

            //Console.WriteLine(adatok[258]);

            //Console.WriteLine();

            //Console.WriteLine(adatok[adatok.Count - 10]);

            //Console.WriteLine();

            //int seged = 0;

            //foreach (var szo in adatok)
            //{
            //    for (int i = 0; i < szo.Length; i++)
            //    {
            //        if (szo[i] == 'S')
            //        {
            //            seged++;
            //        }
            //    }
            //}

            //Console.WriteLine(seged);

            //Console.ReadKey();

            //be.Close();

            //int[] tomb = new int[100000];

            //int db = 0;

            //StreamReader be = new StreamReader("szamok.txt");

            //for (int i = 0; i < tomb.Length; i++)
            //{
            //    if (be.ReadLine() != null)
            //    {
            //        db++;
            //    }
            //}

            //int paratlan = 0;

            //while (!be.EndOfStream)
            //{
            //    tomb[db] = Convert.ToInt32(be.ReadLine());
            //    db++;
            //}

            //Console.WriteLine(paratlan);

            //Console.WriteLine(db);


            string adatok = "254.100.654";

            string[] szoveg = adatok.Split('.');

            foreach (string s in szoveg)
            {
                Console.WriteLine(Convert.ToInt32(s.ToString()) * 2);
            }

            Console.ReadKey();
        }
    }
}
