using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._06
{
    class Program
    {
        static PlacasDeCarro placas = new PlacasDeCarro();

        static void Main(string[] args)
        {
            placas.Add("FND-7714");
            placas.Add("ABC-1234");
            placas.Add("XYZ-9987");

            foreach (var placa in placas)
            {
                Console.WriteLine(placa);
            }
        }
    }
}
