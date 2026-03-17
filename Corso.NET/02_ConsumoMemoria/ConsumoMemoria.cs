using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Corso.NET._02_ConsumoMemoria
{
    [ShortRunJob] // Esegue il benchmark molto più velocemente (meno preciso, ma utile in sviluppo)
    [MemoryDiagnoser]
    //[MinColumn, MaxColumn] // Aggiunge colonne per il tempo minimo e massimo
    //[RankColumn] // Aggiunge una classifica (1°, 2°, ecc.) in base alla velocità
    //[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)] // Opzionale: ordina i risultati per velocità
    public class ConsumoMemoria
    {
        private const int Count = 100;

        [Benchmark]
        public byte[] AllocaByte() => new byte[Count];

        [Benchmark]
        public short[] AllocaInt16() => new short[Count];

        [Benchmark]
        public int[] AllocaInt32() => new int[Count];

        [Benchmark]
        public long[] AllocaInt64() => new long[Count];

        [Benchmark]
        public nint[] AllocaIntPtr() => new nint[Count];

        [Benchmark]
        public Int128[] AllocaInt128() => new Int128[Count];

        public void EseguiAllocazioni()
        {
            AllocaByte();
            AllocaInt16();
            AllocaInt32();
            AllocaInt64();
            AllocaIntPtr();
            AllocaInt128();
        }

    }
}

