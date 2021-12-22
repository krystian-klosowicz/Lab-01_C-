using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sumator
    {
        //i
        //public int[] Liczby;
        //b
        int[] Liczby;

        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

        //c
        public int IleElementow()
        {
            return Liczby.Length;
        }

        //d
        public void WypiszLiczby()
        {
            Console.WriteLine("Liczby: ");
            for(int i = 0; i < Liczby.Length; i++)
            {
                Console.WriteLine(Liczby[i]);
            }

        }

        //e

        public void WypiszPrzedzial(int lowIndex, int highIndex)
        {
            if (lowIndex > highIndex) (lowIndex, highIndex) = (highIndex, lowIndex);
            if (lowIndex < 0) lowIndex = 0;
            if (highIndex >= Liczby.Length) highIndex = Liczby.Length - 1;
            Console.WriteLine("Liczby z przedzialu ["+lowIndex+","+highIndex+"]: ");
            for (int i=lowIndex; i <= highIndex; i++)
            {
                Console.WriteLine(Liczby[i]);
            }
        }



        //ii
        public int Suma(){
            int suma = 0;
            for (int i = 0; i < Liczby.Length; i++)
            {
                suma += Liczby[i];
            }
            return suma;
        }
        //iii
        public int SumaPodziel2()
        {
            int suma = 0;
            for (int i = 0; i < Liczby.Length; i++)
            {
                if (Liczby[i] % 2 == 0) suma += Liczby[i];
            }
            return suma;
        }
    }
}
