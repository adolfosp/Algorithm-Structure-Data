
namespace Algoritmos_Estrutura_Dados.LeetCode.RomanToInteger13;

public class RomanToInteger13
{
    public int RomanToInteger(string s)
    {
        var total = 0;

        var romanAlphabet = new Dictionary<string, int>();
        romanAlphabet.Add("IV", 4);
        romanAlphabet.Add("IX", 9);
        romanAlphabet.Add("XL", 40);
        romanAlphabet.Add("XC", 90);
        romanAlphabet.Add("CD", 400);
        romanAlphabet.Add("CM", 900);
        romanAlphabet.Add("III", 3);
        romanAlphabet.Add("II", 2);
        romanAlphabet.Add("I", 1);
        romanAlphabet.Add("V", 5);
        romanAlphabet.Add("X", 10);
        romanAlphabet.Add("L", 50);
        romanAlphabet.Add("C", 100);
        romanAlphabet.Add("D", 500);
        romanAlphabet.Add("M", 1000);

        if (s.Length < 1 || s.Length > 15) return 0;

        return getNumber(romanAlphabet, s, 0, ref total);
    }

    private int getNumber(Dictionary<string, int> keyValuePairs, string letters, int index, ref int total)
    {
        if (index >= letters.Length) return total;

        if (index + 1 < letters.Length)
        {

            bool hasTwoKey = keyValuePairs.TryGetValue(letters[index] + letters[index + 1].ToString(), out int valueTwoKey);

            if (hasTwoKey)
            {
                total += valueTwoKey;
                index += 2;
                return getNumber(keyValuePairs, letters, index, ref total);

            }
        }

        bool hasKey = keyValuePairs.TryGetValue(letters[index].ToString(), out int value);

        if (hasKey)
        {
            total += value;
        }

        return getNumber(keyValuePairs, letters, index + 1, ref total);

    }
}
