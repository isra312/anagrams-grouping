namespace AnagramsGrouping;

public class Anagrams
{
    public static List<List<string>> GroupAnagrams(List<string> words)
    {
        Dictionary<string, List<string>> anagramsDict = new();
 
        foreach (var word in words)
        {
            var key = String.Concat(word.OrderBy(c => c));

            if (anagramsDict.ContainsKey(key))
                anagramsDict[key].Add(word);
            else
            {
                var anagrams = new List<string>() { word };
                anagramsDict[key] = anagrams;
            }
        }

        return anagramsDict.Values.ToList();
    }
}
