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
        //Lendo o valor no console digitado pelo usuário
        Console.WriteLine("Digite dois números separados por apenas 1 espaço e será mostrado os ímpares que contém na sequência entre esses números");

        //
        string[]? inicialFinal = Console.ReadLine().Split(" ");
        // Criação de uma lista para acomodar os números ímpares
        List<int> impares = new();
        // Utilizando uma varredura com loop For para varrer os números da string inicialFinal do primeiro ao último número, um por um 
        for (int i = int.Parse(inicialFinal[0]); i <= int.Parse(inicialFinal[1]); i++)
        {
            // Selecionando os números ímpares por meio do método if, onde se a divisão do número por 2 der resto diferente de 0, ele adiciona o número na lista de ímpares
            if (i % 2 != 0)
                impares.Add(i);
        }
        //Selecionando os números e organizando na string final "resultado"
        impares.ForEach(i => resultado += (i.ToString() + " "));

        // Mostrando no console o resultado final(números ímpares separados por espaço)
        Console.WriteLine($"Os números ímpares do intervalo são: {resultado}");
    }
}
