using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTraGiuaKi
{
    class Magazine : Document
    {
        public int SoPH { get; set; }
        public string TrangPH { get; set; }
        public Magazine() : base() { }
        public Magazine(int SoPH, string TrangPH) : base()
        {

            this.SoPH = SoPH;
            this.TrangPH = TrangPH;
        }
        public override void Nhap()
        {
            Console.WriteLine("nhap so trang:");
            this.SoPH = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap tenTG:");
            this.TrangPH = Console.ReadLine();
            base.Nhap();
            base.IDDM = 3;
        }
        public override void Xuat()
        {
            Console.WriteLine("SoPh: " + SoPH);
            Console.WriteLine("TrangPH: " + TrangPH);
            base.Xuat();
          
        }
    }
}
