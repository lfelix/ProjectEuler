
using System.Diagnostics;
using ProjectEuler.Domain;

public class ProblemRunner
{
  public static void Run(IProblem problem)
  {
    Console.WriteLine($"=== {problem.Title} ===");

    var stopwatch = Stopwatch.StartNew();
    var result = problem.Solve();
    stopwatch.Stop();

    Console.WriteLine($"Result: {result}");
    Console.WriteLine($"Elapsed: {stopwatch.Elapsed.TotalMilliseconds} ms\n");
  }
}