using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace nauka1
{
    public class P1
    {
        public int dane;
        public static P1 operator + (P1 o1,P1 o2)
        {
            P1 p = new P1();
            p.dane = o1.dane + o2.dane;
            return p;
        }
        public static P1 operator + (P1 o1,int o2)
        {
            P1 p = new P1();
            p.dane = o1.dane + o2;
            return p;
        }
        public static P1 operator + (P1 o1)
        {
            o1.dane++;
            return o1;
        }


    }


        class Program
    {
    public static void Main(string[] args)
        {
            P1 o1 = new P1(); o1.dane = 5;
            P1 o2 = new P1(); o2.dane = 2;
            P1 o3 = o1 + o2 + 6;
            System.Console.WriteLine(o3.dane);
            
            
        }
    }
}
























    // public class Operacje<Szablon, Szablon2>
    // {
    //     Szablon dane;
    //     public void wpisz(Szablon item, Szablon2 item2)
    //     {
    //         dane = item;
    //     } 
    //     public Szablon Pobierz()
    //     {
    //         return dane;
    //     }
    // }
    // public class glowna
    // {
        
//     }
//     public class Y
//     {

//     }
    
    
    
// }

