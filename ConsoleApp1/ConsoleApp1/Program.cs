// See https://aka.ms/new-console-template for more information
int somma;
Console.WriteLine("quante cifre?");
int n = Int32.Parse(Console.ReadLine());
for(int i = 0; i < n ; i++)
{
    Console.WriteLine("dimmi la cifra");
    int cifra = Int32.Parse(Console.ReadLine());
}
Console.WriteLine("inserisci la prima cifra");
int cifra1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("inserisci la seconda cifra");
int cifra2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("inserisci la terza cifra");
int cifra3 = Int32.Parse(Console.ReadLine());
Console.WriteLine("inserisci la quarta cifra");
int cifra4 = Int32.Parse(Console.ReadLine());
cifra1 = cifra1 * 1000;
cifra2 = cifra2 * 100;
cifra3 = cifra3 * 10;
somma = cifra1 + cifra2 + cifra3;
Console.WriteLine("il numero è " + somma);

