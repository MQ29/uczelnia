using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace nauka1
{
    public class c13
    {
        private float liczba;
        public int dane { get; set; }

    }
    public class demo
    {
        public static void Main()
        {
            c13 obiekt = new c13();
            obiekt.dane = 100;
            Console.WriteLine(obiekt.dane);
            Console.In.ReadLine();

        }
    }
    
    
}

