
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApp1
{
    class Programa : Class2 { 
    public int f;
    public int z;

    public Programa(int fc, int zc)
        {
        f = fc;
        z = zc;
     

        }

        public void factorio()
        {



  
            while (f > 0)
            {
                z = z * f;
                f = f - 1;

            }
            Console.WriteLine("Faktorialas: " + z);

    }
}


    class Class2
    {

        public void funkcija()
        {
            DateTime start = DateTime.Now;
            Thread.Sleep(5000);
            double a=3,b=4,d=0;
            int n=0;


            while (d <= Math.Pow(10, 15))
            {
                d = a * b;
                b = a;
                a = d;


                n = n + 1;


            }

            Console.WriteLine("Ats: " + d + " sudauginta " + n + " kartu");
            DateTime end = DateTime.Now;

            TimeSpan ts = (end - start);
            Console.WriteLine("Praejo laiko {0} ms", ts.TotalMilliseconds);


        }

    }
    }
