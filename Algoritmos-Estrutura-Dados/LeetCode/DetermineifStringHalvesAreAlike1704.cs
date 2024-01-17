namespace Algoritmos_Estrutura_Dados.LeetCode;

public class DetermineifStringHalvesAreAlike1704
{
    public bool HalvesAreAlike(string s)
    {
        if (!(s.Length >= 2 && s.Length <= 1000)) return false;

        if (s.Length % 2 != 0)
        {
            Console.WriteLine("O número de elementos do array não é par");
            return false;
        }

        var half = (s.Length / 2);
        var vowel = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        char[] firstPart = new char[half];
        char[] secondPart = new char[half];

        var array = s.ToArray();

        Array.Copy(sourceArray: array,
                   sourceIndex: 0,
                   destinationArray: firstPart,
                   destinationIndex: 0,
                   length: half);

        Array.Copy(sourceArray: array,
                   sourceIndex: half,
                   destinationArray: secondPart,
                   destinationIndex: 0,
                   length: half);

        var quantityVowelFirstPart = firstPart.Count(x => vowel.Contains(x));
        var quantityVowelSecondPart = secondPart.Count(x => vowel.Contains(x));

        return quantityVowelFirstPart == quantityVowelSecondPart;
    }
}

//https://leetcode.com/problems/determine-if-string-halves-are-alike/solutions/4582193/solution-determine-if-string-halves-are-alike/