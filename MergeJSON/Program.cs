using Newtonsoft.Json;
using System;
using XASoft.Extensions;

namespace MergeJSON
{
    class Program
    {
        private class Inicial
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }
        }
        static void Main(string[] args)
        {
            var objA = new { a = 1, b = 2, c = 3, Z = 5200 };
            var newObj = objA.Merger(new { a = "CAMPO NOVO", d = 4, e = 5 });
            newObj.e = "INCLUSÃO";
            newObj.f = 6;
            Console.WriteLine(JsonConvert.SerializeObject(newObj));
            Console.ReadLine();
        }
    }
}
