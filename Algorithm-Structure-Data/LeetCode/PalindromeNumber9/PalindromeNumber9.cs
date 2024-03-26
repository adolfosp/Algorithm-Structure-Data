namespace Algoritmos_Estrutura_Dados.LeetCode.PalindromeNumber9;

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
