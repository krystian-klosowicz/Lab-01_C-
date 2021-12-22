using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Liczba
    {
        //Pola klasy
        int[] cyfry;

        //Konstruktor
        public Liczba(String napis)
        {
            //this.cyfry = new int[napis.Length];
            if (!napis.All(char.IsDigit))
            {
                Console.WriteLine("To nie liczba");
                
            }
            else
            {
                int x = int.Parse(napis);
                this.cyfry = new int[napis.Length];
                for(int i = napis.Length-1; i >= 0; i--)
                {

                    this.cyfry[i] = x % 10;
                    //Console.WriteLine("Index "+i+" element: "+x%10);
                    x = x / 10;
                }
            }

        }

        public void toString()
        {
            for(int i = 0; i < cyfry.Length; i++)
            {
                Console.Write(cyfry[i]);
            }
            Console.WriteLine();
        }

        public int valueOf()
        {
            int x = 0;
            for(int i = 0; i < cyfry.Length; i++)
            {
                x += (int) (Math.Pow(10, cyfry.Length-i-1) * cyfry[i]);
                
            }
            return x;
            
        }

        public void multiple(int x)
        {
            int new_number = this.valueOf()*x;
            int dl = 0;
            int zapasowa = new_number;
            while (zapasowa!=0)
            {
                dl++;
                zapasowa = zapasowa / 10;
            }
            this.cyfry = new int[dl];
            for(int i = dl-1; i >= 0; i--)
            {
                this.cyfry[i] = new_number % 10;
                new_number = new_number / 10;
            }

        }


    }
}
