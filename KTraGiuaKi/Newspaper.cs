using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTraGiuaKi
{
    class Newspaper : Document
    {
       
        public DateTime NgayPH { get; set; }
        public Newspaper() : base() { }
        public Newspaper(DateTime NgayPH) : base()
        {

            this.NgayPH = NgayPH;
           
        }
        public override void Nhap()
        {
            Console.WriteLine("nhap NgayPH:");
            this.NgayPH = DateTime.Parse(Console.ReadLine());
            base.Nhap();
            base.IDDM = 2;
        }
         public override void Xuat()
        {
            Console.WriteLine("NgayPH: " + NgayPH);           
            base.Xuat();
          
        }
    }
}
