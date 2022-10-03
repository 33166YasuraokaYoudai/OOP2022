using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {

            var years = new List<int>();

            Console.WriteLine("出力したい西暦を入力(終了-1)");
            var input = int.Parse(Console.ReadLine());
            while (!(input == -1)) {
                years.Add(input);
                input = int.Parse(Console.ReadLine());

            }
            var books = Library.Books.Where(b => years.Contains(b.PublishedYear));

            foreach (var book in books) {
                Console.WriteLine(book);
            }

            Console.WriteLine();

            Console.WriteLine("昇順：1、降順：2");
            var list = int.Parse(Console.ReadLine());
            if (list == 1) {
                foreach (var asc in books.OrderBy(b=>b.PublishedYear)){
                    Console.WriteLine(asc);
                }

            } else if (list == 2) {
                foreach (var desc in books.OrderByDescending(b => b.PublishedYear)) {
                    Console.WriteLine(desc);
                }

            }

            Console.WriteLine();

            var groups = Library.Books
                                .GroupBy(b => b.PublishedYear)
                                .OrderBy(f => f.Key);
                                   
            
            foreach (var group in groups.Where(b => years.Contains(b.Key))) {
                Console.WriteLine($"{group.Key}年");
                  
                foreach (var book in group.Where(b => years.Contains(b.PublishedYear))) {
                    var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                    Console.WriteLine($"   タイトル:{ book.Title }, 価格:{ book.Price},カテゴリ:{category.Name}");
                }
            }
        }
    }
}
