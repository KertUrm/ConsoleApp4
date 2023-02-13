using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var domains = new Dictionary<string, string>()
            {
                {"est","Estonia"},
                {"lat","Latvia" },
                {"fin","Finland" },
                {"swe","Sweden" }
            };
            foreach (var domain in domains)
            {
                Console.WriteLine($"{domain.Key} - {domain.Value} - {domains.Values.ToList().IndexOf(domain.Value)}");
            }
        }
    }
}
