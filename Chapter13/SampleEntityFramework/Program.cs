using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            //InsertBooks();
            //AddAuthors();
            //AddBooks();
            var books = GetAllBooks();
            Console.WriteLine("-----1-2-----");
            foreach (var book in books){

                Console.WriteLine("タイトル:{0},発行年:{1},著者:{2},誕生日:{3:yyyy/MM}", book.Title,book.PublishedYear,book.Author.Name,book.Author.Birthday);
                
;            }
            Console.WriteLine();//改行
            Console.WriteLine("-----1-3-----");
            var Max = GetBooks();
            foreach (var max in Max) {

                Console.WriteLine("タイトル:{0},発行年:{1},著者:{2},誕生日:{3:yyyy/MM}", max.Title, max.PublishedYear, max.Author.Name, max.Author.Birthday);
            }
            Console.WriteLine();//改行
            Console.WriteLine("-----1-4-----");
            var Old = GetOldBooks();
            foreach (var old in Old.Take(3)) {

                Console.WriteLine("タイトル:{0},発行年:{1},著者:{2},誕生日:{3:yyyy/MM}", old.Title, old.PublishedYear, old.Author.Name, old.Author.Birthday);
            }
            Console.WriteLine();//改行
            using (var db = new BooksDbContext()) {
                var authors = db.Authors
                     .OrderByDescending(b => b.Birthday)
                     .ToList();
                foreach (var author in authors) {
                    Console.WriteLine("{0},{1:yyyy/MM}", author.Name, author.Birthday);
                    foreach (var book in author.Books) {
                        Console.WriteLine("{0} {1}",
                                book.Title, book.PublishedYear,
                                book.Author.Name, book.Author.Birthday);
                    }
                    Console.WriteLine();//改行
                }
            }
            Console.ReadLine();//F5だけでも画面を閉じないように
        }

        //List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };

                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };

                db.Books.Add(book2);
                db.SaveChanges();//データベースの更新
            }
        }

        // List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(author1);
                var author2 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(author2);
                db.SaveChanges();
            }
        }

        // List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "菊池寛");
                var book1 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author1,
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }

        static IEnumerable<Book> GetAllBooks() {
            using(var db = new BooksDbContext()) {
                return db.Books.Include(nameof(Author)).ToList();
            }
        }
        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                return db.Books
                    .Include(nameof(Author))
                    .Where(a => a.Title.Length == db.Books.Max(b => b.Title.Length))
                    .ToList();
            }
        }
        static IEnumerable<Book> GetOldBooks() {
            using (var db = new BooksDbContext()) {
                return db.Books.Include(nameof(Author))
                    .OrderBy(a => a.PublishedYear)
                    .ToList();
            }
        }

    }
}
