using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTraGiuaKi
{
   public class Document
    {
        public int Maxb { get; set; }
        public string TenTL { get; set; }
        public int IDDM { get; set; }
        public string NhaPH { get; set; }

        public Document() { }
        public Document(int Maxb, string TenTL, string NhaPH, int IDDM)
        {
            this.Maxb = Maxb;
            this.TenTL = TenTL;
            this.NhaPH = NhaPH;
            this.IDDM = IDDM;
        }
        public virtual void Nhap()
        {
            Console.WriteLine("nhap maxb:");
            this.Maxb = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap TenTL:");
            this.TenTL = (Console.ReadLine());
            Console.WriteLine("nhap nha phat hanh:");
            this.NhaPH = (Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("ID: " + IDDM);
            Console.WriteLine("Maxb: " + Maxb);
            Console.WriteLine("TenTL: " + TenTL);
            Console.WriteLine("NhaPH: " + NhaPH);
        }
    }

}
