using System;
using System.Linq;

namespace EulerSolver
{

    class Program
    {
        static void Main(string[] args)
        {
            int problemNumber = 0;
            if (args.Length < 2 ||
                args[0] != "-p" ||
                !int.TryParse(args[1], out problemNumber))
            {
                Console.WriteLine("Usage: EulerSolver -p 1");
                Console.WriteLine("  will run the solution for problem 1. Likewise for any other problem number.");
            }

            Console.WriteLine($"Solving problem {problemNumber}...");
            var solver = GetSolver(problemNumber);

            Console.WriteLine(solver.Solve());

        }

        private static ISolver GetSolver(int problemNumber)
        {
            var type = typeof(ISolver);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);

            var chosenType = types
                .FirstOrDefault(t => t.Name.EndsWith($"r{ problemNumber}"));

            var instance = Activator.CreateInstance(chosenType) as ISolver;

            return instance;
        }
    }
}
