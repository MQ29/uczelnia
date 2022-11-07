using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace nauka1
{
    
    public class glowna
    {
        public static void Main()
        {
            Operacje <string> obiekt = new Operacje<string>();
            obiekt.wpisz("tekst");
            string x = obiekt.Pobierz();
            System.Console.WriteLine($"Wynik: {x}");
            
        }
    }
    
    public class Operacje<Szablon>
    {
        Szablon dane;
        public void wpisz(Szablon item)
        {
            dane = item;
        } 
        public Szablon Pobierz()
        {
            return dane;
        }
    }
    
}

