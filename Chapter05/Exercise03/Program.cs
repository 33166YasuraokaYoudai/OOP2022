﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            
        }

        private static void Exercise3_1(string text) {
            int count = text.Count(s => s == ' ');
            Console.WriteLine(count);
        }

        private static void Exercise3_2(string text) {
            
            var result = text.Replace("big", "small");
            Console.WriteLine(result);
        }

        private static void Exercise3_3(string text) {
            var word = text.Split(' ').Length;
            Console.WriteLine("単語数:{0}",word);
        }

        private static void Exercise3_4(string text) {
            var word = text.Split(' ');
            foreach (var item in word.Where(c => c.Length <= 4)) {
                Console.WriteLine(item);
            }
            
            
        }

        private static void Exercise3_5(string text) {

            var array = text.Split(' ').ToArray();
            if (array.Length > 0) {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                var str = sb.ToString();
                Console.WriteLine(str);
            }
        }   
    }
}
