// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

//Console.WriteLine("Hello, World!");

/*
int a = 3;
if (a > 0) Console.WriteLine("Liczba dodatnia");
else Console.WriteLine("Liczba ujemna");

double liczba = 2345.23;

Console.WriteLine(); //cw +2xtab

int i = 32;
float f = 32.005f;
double d = 1234.5678;
bool b = false;


Console.WriteLine(i.ToString());
Console.WriteLine(f.ToString());

Lab01 ob1 = new Lab01(1, 2, 3);
ob1.wypisz();
*/

//Zadanie1
Console.WriteLine("\n--------------------------------------\nZadanie 1");
Licz ob1 = new Licz(1);
//ob1.wartosc = 2;
//Console.WriteLine("Wartosc: "+ob1.wartosc);


ob1.Wypisz();
Console.WriteLine("Dodaj: "+ob1.Dodaj(12));
Console.WriteLine("Dodaj: "+ob1.Dodaj(2));
Console.WriteLine("Dodaj: "+ob1.Dodaj(3));
Console.WriteLine("Dodaj: "+ob1.Odejmij(5));

//Tablice
int[] tab = new int[5] { 1, 2, 3, 4, 5 };
tab[0] = 1;

int[] tab1 = { 2, 25, 23, 23, 423, 423, 4, 23 };

//for (int i = 0; i < tab.Length; i++){
//    Console.WriteLine("tab = "+tab[i]);
//}ctrl+k+c komentarz       ctrl+k+u odkomentowanie

//foreach(int item in tab){
//    Console.WriteLine("tab = " + item);
//}

//Zadanie2
Console.WriteLine("\nZadanie 2");

Sumator ob2 = new Sumator(tab);
Console.WriteLine("Suma: "+ob2.Suma());
Console.WriteLine("Suma podzielnych przez 2: "+ob2.SumaPodziel2());
Console.WriteLine("Ilosc elementow w tablicy: "+ob2.IleElementow());
ob2.WypiszLiczby();
ob2.WypiszPrzedzial(2,0);

//Zadanie3 DATA
Console.WriteLine("\n--------------------------------------\nZadanie 3");
Data d1 = new Data(DateTime.Now);
//wyswietlenie obecnej daty
d1.show();
//data tydzien pozniej
d1.nextWeek();
d1.show();
//data tydzien wczesniej
d1.previousWeek();
d1.show();
Console.WriteLine(d1.getYear());
Console.WriteLine(d1.getMonth());
Console.WriteLine(d1.getDay());
//Zadanie 4 Liczba
Console.WriteLine("\n--------------------------------------\nZadanie 4");
Liczba l1 = new Liczba("26");
Console.Write("toString: ");
l1.toString();
Console.WriteLine("valueOf: "+ l1.valueOf());

int z = 5;
Console.Write("Mnozenie "+l1.valueOf()+" przez "+z+": ");
l1.multiple(z);
Console.Write(l1.valueOf()+"\n");
//
Console.Write("toString: ");
l1.toString();
Console.WriteLine("valueOf: " + l1.valueOf());



