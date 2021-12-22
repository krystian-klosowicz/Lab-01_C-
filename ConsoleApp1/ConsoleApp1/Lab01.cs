using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lab01
    {
        int a; //ten int jest prywatny bo nie ma dopisku public?
        public int b, c;
        //private readonly int d = 10; // tylko do odczytu, wartosc nie moze byc zmodyfikowana
        //ale jest wyjatek mozemy go zedytowac  w konstruktorze klasy np w konstruktorzy pustym piszemy d = 123;

        //Konstruktor bezparametrowy pusty
        public Lab01()
        {
        }

        public Lab01(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //metoda wypisz
        public void wypisz()
        {
            Console.WriteLine("a = " + a + "\nb = " + b + "\nc = " + c );
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
