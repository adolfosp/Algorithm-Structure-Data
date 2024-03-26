# Intuition
The problem aims to check if a number is a palindrome.

# Approach
- The algorithm first gets the rest of division by 10 of the number (x) and just after add (digit) in the result of (revertNumber * 10). This process is repeated as long as the temp is different of 0.

# Complexity
- Time complexity:
O(n)

- Space complexity:
O(1)

# Code
```
public class PalindromeNumber9
{

    public bool PalindromeNumber(int x)
    {
        int reverNum = 0;
        int temp = x;

        while (temp != 0)
        {
            var digit = temp % 10;

            reverNum = (reverNum * 10) + digit;

            temp /= 10;
        }
        if (reverNum < 0) return false;
        return x == reverNum;
    }
}
```