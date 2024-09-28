using AnagramsGrouping;

namespace UnitTests;

public class AnagramsUnitTest
{
    [Fact]
    public void GroupAnagrams_Should_Return_As_Expected()
    {
        List<string> input = ["eat", "tea", "tan", "ate", "nat", "bat"];

        List<List<string>> expected = [["bat"], ["nat", "tan"], ["ate", "eat", "tea"]];

        var result = Anagrams.GroupAnagrams(input);

        var normalizedExpected = expected.Select(group => group.OrderBy(word => word).ToList())
                             .OrderBy(group => group.First())
                             .ToList();

        var normalizedResult = result.Select(group => group.OrderBy(word => word).ToList())
                                     .OrderBy(group => group.First())
                                     .ToList();


        Assert.Equal(normalizedExpected, normalizedResult);
    }
}