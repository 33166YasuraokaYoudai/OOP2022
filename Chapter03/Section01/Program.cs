using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {


        static void Main(string[] args) {

            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            //一致する要素があるかないか
            var exists = list.Exists( s => s[0] == 'A');
            Console.WriteLine(exists);

            //条件と一致する要素を検索し最初に見つかった要素を返す
            var name = list.Find(s => s.Length == 6);
            Console.WriteLine(name);

            //一致するすべての要素を返す
            var names = list.FindAll(s => s.Length <= 5);
            names.ForEach(s => Console.WriteLine(s));
            
        }
    }
}
