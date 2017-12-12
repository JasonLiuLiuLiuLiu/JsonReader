using System;
using Microsoft.Extensions.Configuration;

namespace JsonReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .AddJsonFile("test.json");
            var configuration = builder.Build();
            Console.WriteLine($"name:{configuration["name"]}");
            Console.WriteLine();
            Console.WriteLine($"language:{configuration["item:0:language"]}");
            Console.WriteLine($"tool:{configuration["item:0:tool"]}");
            Console.WriteLine();
            Console.WriteLine($"language:{configuration["item:1:language"]}");
            Console.WriteLine($"tool:{configuration["item:1:tool"]}");
        }
    }
}
