using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var intstr = Console.ReadLine();

            int num;//整数値を入れる変数を用意
            //P126
            if(int.TryParse(intstr,out num)) {
                Console.WriteLine("{0:#:#}", num);//数値への変換成功
            } else {
                Console.WriteLine("できない");//変換失敗
            }
           
        }
    }
}
