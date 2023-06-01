using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using ForSpanForeachLinq;

namespace ForSpanForeachLinq
{
    /// <summary>
    /// A testing class for normal For loop, For loop with a span, Foreach with array, Foreach with span, Parallel Foreach, Parallel LINQ
    /// <br>Made by Software Engineer \ Ahmed A. Mansour</br>
    /// <br>Check my github: <a href="https://www.github.com/xx7Ahmed7xx"></a></br> 
    /// <br>Note: run inside release mode, by calling BenchmarkRunner.Run&lt;TestingClasses&gt;() in the entry point of your program.</br>
    /// </summary>
    [MemoryDiagnoser]
    public class TestingClasses
    {
        public static int[] ints;
        [Params(100,1000, 10000)]
        public static int Size { get; set; }

        static ReadOnlySpan<int> intSpans => new Span<int>(ints);
        //static List<int> intList = new List<int>(ints);

        [GlobalSetup]
        public void SetUp()
        {
            ints = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                ints[i] = i;
            }
        }

        [Benchmark]
        public void ForArray()
        {
            for (int i = 0; i < ints.Count(); i++)
            {

            }
        }

        [Benchmark]
        public void ForSpan()
        {
            for (int i = 0; i < intSpans.Length; i++)
            {

            }
        }

        [Benchmark]
        public void ForeachArray()
        {
            foreach (var item in ints)
            {

            }
        }

        [Benchmark]
        public void ForeachSpan()
        {
            foreach (var item in intSpans)
            {
                
            }
        }

        [Benchmark]
        public void ParallelForeach()
        {
            Parallel.ForEach(ints, (int1) =>
            {

            });
        }

        [Benchmark]
        public void ParallelLINQ()
        {
            ints.AsParallel().ForAll((int1) =>
            {

            });
        }
    }
}
