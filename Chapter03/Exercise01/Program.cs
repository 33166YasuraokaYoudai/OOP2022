﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            Excercise1_1(numbers);
            Console.WriteLine("------------");

            Excercise1_2(numbers);
            Console.WriteLine("------------");
        }

        private static void Excercise1_1(List<int> numbers) {
            var exists = numbers.Exists(s => s % 8 == 0 || s % 9 ==0);
            Console.WriteLine(exists);
        }
        private static void Excercise1_2(List<int> numbers) {
            numbers.ForEach(s => Console.WriteLine(s / 2.0));
            
        }

        
    }
}