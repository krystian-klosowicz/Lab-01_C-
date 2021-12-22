using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Licz
    {
        //i
        //public float wartosc;
        //c
        float wartosc;
        //b
        public Licz(float wartosc)
        {
            this.wartosc = wartosc;
        }
       


        //ii
        public float Dodaj(float a){
            wartosc += a;
            return wartosc;
        }
        //iii
        public float Odejmij(float a){
            wartosc -= a;
            return wartosc;
        }

        public void Wypisz(){
            Console.WriteLine("Wartosc: "+wartosc);
        }
    }
}
