using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sach
    {
        protected string masach, tensach, ngaynhap;
        protected int dongia;
        protected int soluong;
        public Sach()
        {
            this.masach = "001";
            this.tensach = "101 chuchodom";
            this.dongia = 70000;
            this.soluong = 7;
            this.ngaynhap = "9/03/2019";
        }
        public Sach(string masach, string tensach, string ngaynhap, int dongia, int soluong)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.dongia = dongia;
            this.soluong = soluong;
            this.ngaynhap = ngaynhap;
        }
        public void HienThi()
        {
            Console.WriteLine("Ma sach la:{0}", masach);
            Console.WriteLine("Ten sach la:{0}", tensach);
            Console.WriteLine("Ngay nhap sach la:{0}", ngaynhap);
            Console.WriteLine("Don gia sach la:{0}", dongia);
            Console.WriteLine("So luong la:{0}", soluong);

        }
    }

    class SachGiaoKhoa : Sach
    {
        string tinhtrang;
        public SachGiaoKhoa() : base()
        {
            this.tinhtrang = "moi"; //cu hoac moi
        }
        public SachGiaoKhoa(string masach, string tensach, string ngaynhap, int dongia, int soluong, string tinhtrang) : base(masach, tensach, ngaynhap, dongia, soluong)
        {
            this.tinhtrang = tinhtrang;
        }

        public int Tinhtien()
        {
            if (this.tinhtrang.Equals("moi"))

                return (soluong * dongia);
            else
             return (soluong * dongia / 2);
            
        }
        public void In()
        {
            base.HienThi();
            Console.WriteLine("Co tien la {1}", masach, this.Tinhtien());
        }
        public new void Nhap(int i)
        {
            Console.WriteLine("Nhap thong tin sgk thu {0}",i+1);
            Console.WriteLine("Nhap ma sach");
            masach = Console.ReadLine();
            Console.WriteLine("Nhap ten sach");
            tensach = Console.ReadLine();
            Console.WriteLine("Nhap ngay");
            ngaynhap = Console.ReadLine();
            Console.WriteLine("Nhap don gia");
            dongia = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong");
            soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tinh trang");
            tinhtrang = Console.ReadLine();
        }
    }
    public class SachMain
    {


        public static void Main(string[] args)
        {
            SachGiaoKhoa[] sgk = new SachGiaoKhoa[100];
            Console.WriteLine("So luong sgk can nhap:\t");
            int n;
            n= int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {  sgk[i] = new SachGiaoKhoa("0005", "bai tap c", "01/01/2001", 80000, 6, "moi");

                sgk[i].Nhap(i);
                sgk[i].In();
            }
            Console.ReadKey();

        }

      
    }
   
}
