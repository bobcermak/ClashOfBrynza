using System.Text;

public class WordGenerator
{
    private static readonly char[] Consonants = "bcdfghjklmnpqrstvwxyz".ToCharArray();
    private static readonly char[] Vowels = "aeiou".ToCharArray();
    private static readonly Random _random = new Random();

    public string Generate(int length)
    {
        StringBuilder word = new StringBuilder();
        
        for (int i = 0; i < length; i++)
        {
            char[] list = (i % 2 == 0) ? Consonants : Vowels;
            word.Append(list[_random.Next(list.Length)]);
        }

        return word.ToString();
    }
}