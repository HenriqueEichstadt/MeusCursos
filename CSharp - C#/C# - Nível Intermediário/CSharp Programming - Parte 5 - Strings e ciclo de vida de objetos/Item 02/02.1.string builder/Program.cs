using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml;

namespace _02._1.string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string materias = "";
            materias = materias + "Português";
            Console.WriteLine(materias);
            materias = materias + ", Matemática";
            Console.WriteLine(materias);
            materias = materias + ", Geografia";
            Console.WriteLine(materias);

            ///<i mage url="$(ProjectDir)/img1.png"/>
        }
    }
}
