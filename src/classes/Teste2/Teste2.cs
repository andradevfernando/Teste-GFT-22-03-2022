namespace DesafioGFT_22_03_2022.src.classes.Teste2;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
public class Teste2
{
    public static void Teste()
    {
        // Instanciando a classe Pessoa por meio da criação da pessoa "Fernando"
        Pessoa fernando = new("Fernando Vinicius Atanazio de Andrade", "Rua dos alfeneiros Nº 4", 14998539324);
        //Criação de uma lista para adicionar eventuais pessoas criadas
        List<Pessoa> pessoas = new();
        // Adição das pessoas criadas
        pessoas.Add(fernando);
        //Apresentando cada pessoa da lista "pessoas" no console
        pessoas.ForEach(pessoa => Console.WriteLine($"A pessoa {pessoa.nome}, mora no endereço: {pessoa.endereco} e possui número de telefone: {pessoa.telefone}"));
    }
}
