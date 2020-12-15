using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class Compute
    {
        private static int Fib(int i) { 
            if(i<=2) return 1;
            return Fib(i-2) + Fib(i-1);
        }
    
        private static ConcurrentBag<int> ConcurrentBag(string[] args)
        {
            var parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = Environment.ProcessorCount;
            Console.WriteLine(Environment.ProcessorCount);
            var results = new ConcurrentBag<int>();
            Parallel.ForEach(args, parallelOptions, arg =>
            {
                var result = Fib(int.Parse(arg));
                results.Add(result);
            });
            return results;
        }
        public static IList<int> Execute(string[] args)
        {
            return ConcurrentBag(args).ToArray();
        }
    }

}