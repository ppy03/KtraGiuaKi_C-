using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTraGiuaKi
{
    class Category
    {
        public int IDDM { get; set; }
        public string NameCategory { get; set; }

        public static List<Category> GetCategories()
        {
            return new List<Category>() {
            new Category{IDDM = 1, NameCategory = "Book"},
            new Category{IDDM = 2, NameCategory = "Newspaper"},
            new Category{IDDM = 3, NameCategory = "Magazine"},
        };

        }

    }
}