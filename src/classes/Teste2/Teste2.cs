namespace DesafioGFT_22_03_2022.src.classes.Teste2;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
public class Teste2
{
    public static void Teste()
    {
        Pessoa fernando = new("Fernando Vinicius Atanazio de Andrade", "Rua dos alfeneiros Nº 4", 14998539324);
        List<Pessoa> pessoas = new();
        pessoas.Add(fernando);
        pessoas.ForEach(pessoa => Console.WriteLine($"A pessoa {pessoa.nome}, mora no endereço: {pessoa.endereco} e possui número de telefone: {pessoa.telefone}"));
    }
}
