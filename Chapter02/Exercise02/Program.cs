using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom") {
                
            }

            PrintInchToMeterList(1, 10);
        }
        //インチからメートルへの対応を出力
        private static void PrintInchToMeterList(int start, int stop) {
            for (int inch = 1; inch <= 10; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0}  インチ = {1:0.0000} メートル", inch, meter);
                }
            }
    }
}
