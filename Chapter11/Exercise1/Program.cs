using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var file = "sports.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            //Exercise1_4(file, newfile);

            //確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
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
                                           Name = (string)a.Element("name").Attribute("kanji"),
                                           Start = (string)a.Element("firstplayed"),
                                       }).OrderBy(a => a.Start);
            foreach (var item in xSample) {
                Console.WriteLine("{0} ({1})",item.Name,item.Start);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xSample = xdoc.Root.Elements()
                                      .Select(a => new {
                                          Name = (string)a.Element("name"),
                                          Team = (string)a.Element("teammembers"),
                                      }).OrderByDescending(a => int.Parse(a.Team)).FirstOrDefault();
            Console.WriteLine("{0} ({1})",xSample.Name,xSample.Team);
        }
        private static void Exercise1_4(string file, string newfile) {
            var sports = new XElement("ballsport",
                            new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                            new XElement("teammembers", "11"),
                            new XElement("firstplayed", "1863")
                        );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(sports);
            xdoc.Save(newfile);
        }
    }
}
