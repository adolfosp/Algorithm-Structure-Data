namespace Algoritmos_Estrutura_Dados.LeetCode.LongestCommonPrefix14;

public class LongestCommonPrefix14
{
    public string longestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";

        int minLength = int.MaxValue;
        foreach (string str in strs)
        {
            minLength = Math.Min(minLength, str.Length);
            //pega o tamanho da menor palavra porque o máximo de prefixo que pode ter é o próprio tamanho da menor palavra
        }

        for (int i = 0; i < minLength; i++)
        {
            char currentChar = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                //verifica se a letra atual é igual nas demais palavras
                if (strs[j][i] != currentChar)
                {
                    return strs[0].Substring(0, i);
                }
            }
        }

        return strs[0].Substring(0, minLength);
    }

}
