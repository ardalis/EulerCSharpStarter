using EulerSolver.Solvers;
using Xunit;

namespace EulerSolverTests
{
    public class SumMultiplesUpTo
    {
        [Fact]
        public void Returns23Given10()
        {
            var solver = new Solver1();

            var result = solver.SumMultiplesUpTo(10);

            // TODO: Uncomment and verify
            // Assert.Equal(23, result);
        }

        [Fact]
        public void ReturnsXGiven1000()
        {
            var solver = new Solver1();

            var result = solver.SumMultiplesUpTo(1000);

            // TODO: Uncomment and verify
            // Assert.Equal(23, result);
        }
    }
}
