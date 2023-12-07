using ConsoleApp2.Services;

public class AlmostAnagram : IAlmostAnagram
{
    private List<string> words;

    public AlmostAnagram(List<string> words)
    {
        this.words = words;
    }

    public int FindAlmostAnagram(string word)
    {
        int count = 0;
        foreach (string w in words)
        {
            if (IsAlmostAnagram(word, w))
            {
                count++;
            }
        }
        return count;

    }

    private bool IsAlmostAnagram(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        int[] count = new int[26];

        for (int i = 0; i < word1.Length; i++)
        {
            count[word1[i] - 'a']++;
            count[word2[i] - 'a']--;
        }

        int nonZeroCount = 0;
        for (int i = 0; i < 26; i++)
        {
            if (count[i] != 0)
            {
                nonZeroCount++;
            }
        }

        return nonZeroCount <= 2;
    }
}
