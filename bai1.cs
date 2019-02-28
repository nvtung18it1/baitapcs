using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class tinhtong
    {  //cau a
        public static int a(int n)
        { int s;
        
        if (n % 2 == 0)
            s = -n / 2;
        else s = (n / 2) + 1;
        return s;
        }
        //cau b
        public static float b(int n)
         {float s=0;
         for (float i = 1; i <= n; i++)
         { s += 1 / i; }
         return s;
        }
        //cau c
        public static int c(int n)
        { int s=0;
        for (int i =1 ; i <=n; i++)
            s += i;
        return s;
        }
        //cau d
        public static int d(int n)
        { int s=0;
        for (int i = 1; i < n; i++)
            if (n % i == 0)
                s += i;
        return s;
            }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao n:\n");
            n = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Tong cau a la:\t{0}",a(n));
            Console.WriteLine("Tong cau b la:\t{0}", b(n));
            Console.WriteLine("Tong cau c la:\t{0}", c(n));
            Console.WriteLine("Tong cau d la:\t{0}", d(n));

            Console.ReadKey();
        }
    }
}
