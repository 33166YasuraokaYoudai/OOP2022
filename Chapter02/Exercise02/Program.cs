using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom") {
                PrintInchToMeterList(1, 10);
            }
            else if (args.Length >= 1 && args[0] == "-toi")
                PrintMeterToInchList(1, 10);
            
        }
        //インチからメートルへの対応を出力
        private static void PrintInchToMeterList(int start, int stop) {
            for (int inch = 1; inch <= 10; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} in = {1:0.0000} m", inch, meter);
                }
            }
        //メートルからインチへの対応を出力
        private static void PrintMeterToInchList(int start, int stop) {
            for (int meter = 1; meter <= 10; meter++) {
                double inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} in", meter, inch);
            }
        }
    }
}
