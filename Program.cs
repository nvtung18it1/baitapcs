using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class doantau
    {
        int sokhach;
        string matau;
        int tien;
        public void nhaptt()
        {
            Console.WriteLine("Nhap ma tau:\t");
            this.matau = Console.ReadLine();
            Console.WriteLine("Nhap so luong khach:\t");
            this.sokhach = Convert.ToInt32(Console.ReadLine());
         }
       public void intien()
        {
            Console.WriteLine("Ma tau {0} so tien la {1}", this.matau,this.tien);
        }
       public void tinhtien()
       {
           if (this.sokhach < 100)
               this.tien = this.sokhach * 100000;
           else this.tien=this.sokhach*80000;
          
      }

        static void Main(string[] args)
        {
            doantau a= new doantau();
            a.nhaptt();
            a.tinhtien();
            a.intien();
            Console.ReadKey();
        }
    }
}
