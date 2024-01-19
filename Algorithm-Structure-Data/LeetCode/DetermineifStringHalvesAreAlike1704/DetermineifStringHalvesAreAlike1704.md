# Intuition
The problem aims to check if two halves of a given string have the same number of vowels. The solution involves splitting the string into two equal parts and counting the vowels in each part. By comparing these counts, we can determine if the halves are alike in terms of vowel frequency.

# Approach
1. Input Validation: First, ensure the string's length is within the specified range (2 to 1000) and is even. If not, return false.
2. Vowel Set-Up: Define a character array containing all vowels (both lowercase and uppercase) for easy comparison.
3. Splitting String: Divide the string into two equal halves.
4. Counting Vowels: Iterate through each half and count the number of vowels using the predefined vowel array.
5. Comparison: Compare the vowel counts from both halves. If they are equal, return true; otherwise, false.

# Complexity

- Time complexity:
Time complexity: The solution has a time complexity of O(n) where n is the length of the string. This is because each character in the string is visited once to count the vowels.

- Space complexity:
The space complexity is O(1), disregarding the input and output. The space used for storing vowels and the two halves of the string does not grow with the size of the input string.

# Code
```csharp
public class Solution {
   public bool HalvesAreAlike(string s)
{
    if (!(s.Length >= 2 && s.Length <= 1000)) return false;

    if (s.Length % 2 != 0)
    {
        Console.WriteLine("O número de elementos do array não é par");
        return false;
    }

    var metade = (s.Length / 2);
    var vogais = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    char[] primeiraParte = new char[metade];
    char[] segundaParte = new char[metade];

    var array = s.ToArray();

    Array.Copy(sourceArray: array,
               sourceIndex: 0,
               destinationArray: primeiraParte,
               destinationIndex: 0,
               length: metade);

    Array.Copy(sourceArray: array,
               sourceIndex: metade,
               destinationArray: segundaParte,
               destinationIndex: 0,
               length: metade);

    var quantidadeVogaisPrimeiraParte = primeiraParte.Count(x => vogais.Contains(x));
    var quantidadeVogaisSegundaParte = segundaParte.Count(x => vogais.Contains(x));

    return quantidadeVogaisPrimeiraParte == quantidadeVogaisSegundaParte;
}
}
```