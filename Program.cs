using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinh_vien
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so luong sinh vien: ");
            n = Int32.Parse(Console.ReadLine());
           
            Sinhvien[] sinhvien = new Sinhvien[n];
            for (int i = 0; i < n; i++)
            {
                sinhvien[i] = new Sinhvien();
                sinhvien[i].nhapthongtin();
                sinhvien[i].tinhTb();
                sinhvien[i].In();
            }
            
            float min = sinhvien[0].tinhTb();
            for (int i = 1; i < n; i++)
            {
                if (sinhvien[i].tinhTb() < min) min = sinhvien[i].tinhTb();
            }
            Console.WriteLine("SV co diem thap nhat la: {0}", min);
            
            for (int i = 0; i < n; i++)
            {
                if (sinhvien[i].maSV.Contains("18I"))
                    Console.WriteLine("SV ma {0} co diem  Tb la {1} co chua chu 18I", sinhvien[i].maSV, sinhvien[i].tinhTb());
            }
        
            Sinhvien tmp;
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 1; j < n; j++)
                        if (sinhvien[i].tinhTb() > sinhvien[j].tinhTb())
                        {
                            tmp = sinhvien[i];
                            sinhvien[i] = sinhvien[j];
                            sinhvien[j] = tmp;
                        }
                }
            }

            Console.WriteLine("sinh vien sap xep theo thu tu giam dan: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien ma {0} co diem tb {1} ", sinhvien[i].maSV, sinhvien[i].tinhTb());
            }
            Console.ReadLine();
        }
    }
}
