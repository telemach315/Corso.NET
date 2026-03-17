using BenchmarkDotNet.Running;

namespace Corso.NET._02_ConsumoMemoria
{
    public static class Benchmarks
    {
        public static void EseguiBenchmark()
        {
            BenchmarkRunner.Run<ConsumoMemoria>();
        }
    }
}
