# Intuition
The problem aims to convert roman numbers to integers. The algorithm uses a dictionary to store the roman numbers and their respective values. The algorithm iterates over the string and checks if the current letter and the next one form a valid roman number. If so, the algorithm adds the value to the total and increments the index by 2. Otherwise, the algorithm adds the value of the current letter to the total and increments the index by 1. The process is repeated until the index is greater than or equal to the length of the string. The algorithm returns the total.

# Approach
1. Create a dictionary to store the roman numbers and their respective values.
2. Check if the length of the string is less than 1 or greater than 15. If so, return 0.
3. Call the getNumber function with the dictionary, the string, the index, and the total as parameters.
4. The getNumber function receives the dictionary, the string, the index, and the total as parameters.
5. Check if the index is greater than or equal to the length of the string. If so, return the total.
6. Check if the current letter and the next one form a valid roman number. If so, add the value to the total and increment the index by 2.
7. Otherwise, add the value of the current letter to the total and increment the index by 1.
8. Repeat the process until the index is greater than or equal to the length of the string.
9. Return the total.

# Complexity
- Time complexity:
O(n)

- Space complexity:
O(n)

# Code
```
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
```