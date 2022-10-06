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

            /*
            foreach (var book in books) {
                Console.WriteLine(book);
            }*/

            Console.WriteLine();//空白行

            //昇順or降順
            Console.WriteLine("昇順：1、降順：2");
            var list = int.Parse(Console.ReadLine());
            if (list == 1) {
                //昇順
                foreach (var asc in books.OrderBy(b=>b.PublishedYear)){
                    //Console.WriteLine(asc);
                }

            } else if (list == 2) {
                //降順
                foreach (var desc in books.OrderByDescending(b => b.PublishedYear)) {
                    //Console.WriteLine(desc);
                }

            }

            Console.WriteLine();

            var selected = Library.Books
                                .Where(b => years.Contains(b.PublishedYear))
                                .Join(Library.Categories,          //結合する2番目のシーケンス
                                      book => book.CategoryId,     //対象シーケンスの結合キー
                                      category => category.Id,
                                      (book, category) => new {
                                          Title = book.Title,
                                          category = category.Name,
                                          PublishedYear = book.PublishedYear,
                                          Price = book.Price
                                          
                                      }
                                );
                         
            foreach (var book in selected.OrderByDescending(a=>a.PublishedYear).ThenBy(x=>x.category)) {
                //Console.WriteLine($"{book.PublishedYear}年");
                //var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                Console.WriteLine($"出版年:{ book.PublishedYear},タイトル:{ book.Title },カテゴリ:{book.category} 合計{book.Price}");
                Console.WriteLine();
            }
        }
    }
}
