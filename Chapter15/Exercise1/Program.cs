using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var price = Library.Books.OrderByDescending(a => a.Price).First();
            Console.WriteLine(price);
        }

        private static void Exercise1_3() {
            var group = Library.Books.GroupBy(a => a.PublishedYear)
                                     .OrderBy(a => a.Key);
            foreach (var item in group) {
                Console.WriteLine($"{item.Key}年 {item.Count()}冊");
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books.OrderByDescending(a => a.PublishedYear)
                                     .ThenByDescending(b => b.Price)
                                     .Join(Library.Categories,
                                       book => book.CategoryId,
                                       category => category.Id,
                                       (book, category) => new {
                                           Title = book.Title,
                                           PublishedYear = book.Price,
                                           Price = book.Price,
                                           Name = category.Name
                                       });
            foreach (var book in books) {
                Console.WriteLine($"発行年:{book.PublishedYear} 価格:{book.Price} タイトル:{book.Title}({book.Name})");
            }
           
        }

        private static void Exercise1_5() {
            var names = Library.Books
                                 .Where(b => b.PublishedYear == 2016)
                                 .Join(Library.Categories,
                                       book => book.CategoryId,
                                       category => category.Id,
                                       (book, category) => category.Name)
                                       .Distinct();
            foreach (var name in names) {
                Console.WriteLine(name);
            }                              
                                
        }

        private static void Exercise1_6() {

            var books = Library.Categories.GroupJoin(Library.Books,
                                        c => c.Id,
                                        b => b.CategoryId,
                                        (c, booka) => new { Category = c.Name, Books = booka });
            foreach (var groups in books.OrderBy(a => a.Category)) {
                Console.WriteLine($"#{groups.Category}");
                foreach (var book in groups.Books) {
                    Console.WriteLine($"    {book.Title} ({book.PublishedYear}年)");
                }
            }
        }

        private static void Exercise1_7() {
            var group = Library.Books.Where(a=>a.CategoryId == 1)
                                     .GroupBy(b => b.PublishedYear)
                                     .OrderBy(x => x.Key);
            foreach (var book in group) {
                Console.WriteLine($"#{book.Key}年");
                foreach (var books in book) {
                    Console.WriteLine($"   {books.Title}");
                }
            }
        }

        private static void Exercise1_8() {
            var group = Library.Categories.GroupJoin(Library.Books,
                                                    category => category.Id,
                                                    book => book.CategoryId,
                                                    (category, books) => new {
                                                        Category = category.Name,
                                                        Count = books.Count()
                                                    });
            foreach (var book in group.Where(a=>a.Count >= 4)) {
                Console.WriteLine(book.Category);
            }
        }
    }
}
