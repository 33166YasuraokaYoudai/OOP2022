using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Exercise1 {
    class ToHankakuProcessor : TextProcessor{

     
        protected override void Execute(string line) {
            String s = Regex.Replace(line,"[０-９]",p => ((char)(p.Value[0]-'０' + '0')).ToString());
            Console.WriteLine(s);
        }
        
    }
}
