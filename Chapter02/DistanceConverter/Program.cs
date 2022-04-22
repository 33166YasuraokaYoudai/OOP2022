using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                PrintFeetTometerList(1,10);
            }
            else {
                //メートルからフィートへの対応表を出力
                PrintMeterToFeetList(1,10);
            }
        }

        
        //メータからフィートへの対応を出力
        private static void PrintMeterToFeetList(int start, int stop) {
            for (int meter = 1; meter <= 10; meter++) {
                double feet = MeterToFeet(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }
        //フィートからメータへの対応を出力
        private static void PrintFeetTometerList(int start, int stop) {
            for (int feet = 1; feet <= 10; feet++) {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        //フィートからメートルを求める
        static double FeetToMeter(int feet) {
            return feet * 0.3048;
        }
        //メートルからフィートを求める
        static double MeterToFeet(int meter) {
            return meter / 0.3048;
        }
    }
}
