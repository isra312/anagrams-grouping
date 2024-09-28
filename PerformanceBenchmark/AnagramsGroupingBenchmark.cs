using AnagramsGrouping;
using BenchmarkDotNet.Attributes;

namespace PerformanceBenchmark;

public class AnagramsGroupingBenchmark
{
    private readonly List<string> input = ["eat", "tea", "tan", "ate", "nat", "bat"];
    
    [Benchmark]
    public void GroupAnagramsBenchmark()
    {
        Anagrams.GroupAnagrams(input);
    }
}
