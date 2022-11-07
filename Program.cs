using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace nauka1
{
    public class Operacje<Szablon, Szablon2>
    {
        Szablon dane;
        public void wpisz(Szablon item, Szablon2 item2)
        {
            dane = item;
        } 
        public Szablon Pobierz()
        {
            return dane;
        }
    }
    public class glowna
    {
        public static void Main()
        {
            Operacje <Y, int> obiekt = new Operacje<Y, int>();
            obiekt.wpisz(new Y(), 14);
            Y x = obiekt.Pobierz();
            System.Console.WriteLine("Wynik");
            
        }
    }
    public class Y
    {

    }
    
    
    
}

