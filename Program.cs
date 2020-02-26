using BenchmarkDotNet.Running;

namespace simd_workshop
{
   public class Program
    {
      public static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
