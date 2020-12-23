using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "In 2020 I would like to run ALL languages in one VM.";
            long total = 0, start = DateTimeOffset.Now.ToUnixTimeMilliseconds(), last = start;
            for (int i = 1; i < 10_000_000; i++)
            {
                total += sentence.Where(p =>char.IsUpper(p)).Count();
                if (i % 1_000_000 == 0)
                {
                    long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    Console.WriteLine($"{i / 1_000_000} ({now - last} ms)");
                    last = now;
                }
            }
            Console.WriteLine($"total: {total} ({DateTimeOffset.Now.ToUnixTimeMilliseconds() - start} ms)");
            Console.ReadLine();
        }
    }
}
