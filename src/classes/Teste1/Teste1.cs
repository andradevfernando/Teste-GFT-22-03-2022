namespace DesafioGFT_22_03_2022.src.classes.Teste1;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
public class Teste1
{
    public static void Teste()
    {
        // Inicializando variáveis
        string resultado = "";
        string[]? inicialFinal = Console.ReadLine().Split(" ");
        List<int> impares = new();

        // Utilizando uma varredura com loop For para varrer os números da string inicialFinal do primeiro ao último número, um por um
        for (int i = int.Parse(inicialFinal[0]); i <= int.Parse(inicialFinal[1]); i++)
        {
            if (i % 2 != 0)
                impares.Add(i);
        }
        impares.ForEach(i => resultado += (i.ToString() + " "));
        Console.WriteLine(resultado);
    }
}
