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

//https://leetcode.com/problems/determine-if-string-halves-are-alike/solutions/4582193/solution-determine-if-string-halves-are-alike/