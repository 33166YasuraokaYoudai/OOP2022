using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            TextProcessor.Run<ToHankakuProcessor>(@"\\172.16.45.1\学生共有\#infosys2022\オブジェクト指向プログラミング\２期目\Sample.txt");

        }
    }
}
