using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Duygu");
            isimler.Add("Fatih");
            

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);

            List<int> sayilar = new List<int>();
            sayilar.Add(2);
            sayilar.Add(4);
            Console.WriteLine(sayilar.Count);

        }
       }
    }

