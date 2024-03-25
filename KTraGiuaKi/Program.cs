using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTraGiuaKi
{
    internal class Program
    {
        static List<Document> Listdocuments = new List<Document>();
        static void Main(string[] args)
        {
            Console.WriteLine("Cau 1");
            char c = 'y';
            while (c == 'y')
            {
                Console.WriteLine("Chon danh muc (1. Book, 2.Newspaper, 3. Magazine)");
                int cate = int.Parse(Console.ReadLine());
                switch (cate)
                {
                    case 1:
                        Book document1 = new Book();
                        document1.BookNhap();
                        document1.BookXuat();
                        Listdocuments.Add(document1);
                        break;
                    case 2:
                        Newspaper document2 = new Newspaper();
                        document2.NewspaperNhap();
                        document2.NewspaperXuat();
                        Listdocuments.Add(document2);

                        break;
                    case 3:
                        Magazine document3 = new Magazine();
                        document3.MagazineNhap();
                        document3.MagazineXuat();
                        Listdocuments.Add(document3);
                        break;
                }
                Console.Write("ban muon tiep tuc? (Y/N): ");
                c = char.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Cau 2");

            Console.WriteLine("Chon danh muc (1. Book, 2.Newspaper, 3. Magazine)");
            int cate2 = int.Parse(Console.ReadLine());
            var query2_339 = Listdocuments.Where(x => x.IDDM == cate2).ToList();
            foreach (var item in query2_339)
            {
                item.Xuat();
            }

            Console.WriteLine("Cau 3");

            var newspagerList = Listdocuments.OfType<Newspaper>().ToList();
            var query_339 = newspagerList.Where(x => (x.NgayPH.Month == 3) && (x.NgayPH.Year) == 2024).ToList();
            Console.WriteLine("Bao co ngay phat hanh trong thang 3 2024");
            foreach (var item in query_339)
            {
                Console.WriteLine(item.TenTL);
            }

            Console.ReadKey();

        }
    }
}
