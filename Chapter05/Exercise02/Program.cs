using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var intstr = Console.ReadLine();


            if (int.TryParse(intstr, out var IntStr)) {
                Console.WriteLine("{0:N}", IntStr);
            } else {
                Console.WriteLine("無理");
            }
        }
    }
}
