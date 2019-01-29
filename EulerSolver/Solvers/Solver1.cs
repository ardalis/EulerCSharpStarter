namespace EulerSolver.Solvers
{
    public class Solver1 : ISolver
    {
        public int SumMultiplesUpTo(int max)
        {
            int sum = 0;
            // TODO: Implement summing multiples of 3 or 5 less than max
            return sum;
        }

        public string Solve()
        {
            return SumMultiplesUpTo(1000).ToString();
        }
    }
}
