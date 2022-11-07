using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace nauka1
{
    
    public class glowna
    {
        public static void Main()
        {
            Operacje <Y> obiekt = new Operacje<Y>();
            obiekt.wpisz(new Y());
            Y x = obiekt.Pobierz();
            System.Console.WriteLine($"Wynik: {x}");
            
        }
    }
    public class Y
    {

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

