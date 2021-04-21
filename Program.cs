using System;
using System.Linq;
using System.Xml.Linq;
using System.IO;

namespace Task14_1
{
    class Program
    {
        static void Main()
        {
            string txtFileName = "in.txt";
            string xmlFileName = "out.xml";

            string[] lines = File.ReadAllLines(txtFileName);

            XDocument xDoc = new XDocument();
            XElement xRoot = new XElement("root");
            foreach (XElement xLine in from line in lines
                                       let xLine = new XElement("line", line)
                                       select xLine)
            {
                xRoot.Add(xLine);
            }

            xDoc.Add(xRoot);
            xDoc.Save(xmlFileName);

            Console.WriteLine(xDoc);
            Console.ReadKey();
        }
    }
}
