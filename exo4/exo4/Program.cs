using System;
using System.Collections.Generic;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            var mois =new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            foreach (string x in mois)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("=======================================================");
            Console.WriteLine(mois[2]);
            Console.WriteLine("=======================================================");
            Console.WriteLine(mois[4]);
            Console.WriteLine("=======================================================");
            for (int i = 0; i < mois.Count; i++)
            {
                Console.WriteLine(mois[i]);
            }
            Console.WriteLine("=======================================================");
            mois[7] = "August!!!!";
            Console.WriteLine(mois[7]);
            Console.WriteLine("=======================================================");
            mois.Insert(0, "somting");
            foreach (string x in mois)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("=======================================================");
            mois.Remove("somting");
            foreach (string x in mois)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("=======================================================");
            int indice = mois.IndexOf("February");
            Console.WriteLine(indice);

            Console.WriteLine("========================================================");
            mois.Sort();
            foreach (string x in mois)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("========================================================");
            string[] array = new string[15];
            mois.CopyTo(array);
            foreach (string i in array)
            {
                Console.WriteLine(i);
            }

        }
    }
}
