using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTraGiuaKi
{
    public class Book : Document
    {
       
        public string TenTG { get; set; }
        public int SoTrang { get; set; }
        public Book() : base() { }
        public Book( string TenTG, int SoTrang) : base()
        {
            
            this.TenTG = TenTG;
            this.SoTrang = SoTrang;
        }
        public  void BookNhap()
        {
            Console.WriteLine("nhap tenTG:");
            this.TenTG = Console.ReadLine();
            Console.WriteLine("nhap so trang:");
            this.SoTrang = int.Parse(Console.ReadLine());
            base.Nhap();
            base.IDDM = 1;         
        }
        public  void BookXuat()
        {
            Console.WriteLine("TenTG: " + TenTG);
            Console.WriteLine("SoTrang: " + SoTrang);
            base.Xuat();
          
        }
    }

}
