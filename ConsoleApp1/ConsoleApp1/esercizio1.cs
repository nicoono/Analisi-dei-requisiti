// See https://aka.ms/new-console-template for more information
int somma = 0;
Console.WriteLine("inserisci la prima cifra");//2
int cifra1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("inserisci la seconda cifra");
int cifra2 = Int32.Parse(Console.ReadLine());//8
Console.WriteLine("inserisci la terza cifra");
int cifra3 = Int32.Parse(Console.ReadLine());//9
Console.WriteLine("inserisci la quarta cifra");
int cifra4 = Int32.Parse(Console.ReadLine());//1
cifra1 = cifra1 * 1000;
cifra2 = cifra2 * 100;
cifra3 = cifra3 * 10;
somma = cifra1 + cifra2 + cifra3 + cifra4;
Console.WriteLine("il numero è " + somma);