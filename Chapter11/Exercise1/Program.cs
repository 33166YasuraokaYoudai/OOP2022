using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xSample = xdoc.Root.Elements()
                                        .Select(a => new {
                                            Name = (string)a.Element("name"),
                                            Team = (string)a.Element("teammembers"),
                                        });
            foreach (var s in xSample) {
                Console.WriteLine("{0} {1}", s.Name, s.Team);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xSample = xdoc.Root.Elements()
                                       .Select(a => new {
                                           Name = (string)a.Attribute("kanji"),
                                           Start = (string)a.Element("firstplayed"),
                                       });
            foreach (var item in xdoc.Root.Elements()) {
                
                Console.WriteLine("{0} ({1})",item.Name,item);
            }
        }

        private static void Exercise1_3(string file) {
           
        }

        private static void Exercise1_4(string file, string newfile) {
          
        }
    }
}
