namespace DesafioGFT_22_03_2022.src.classes.Teste3;
using DesafioGFT_22_03_2022.src.interfaces;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
public class Teste3
{
    public static void Teste()
    {
        //Instanciando as 2 classes filhas herdadas da classe mãe(Conta)
        //Classe ContaCorrente
        ContaCorrente conta1 = new(1, "Carlos", 1000.00m);
        //Calculando o rendimento antes de calcular o imposto, pois se não o fizer, o método CalcularImposto retornará o valor 0
        conta1.Rendimento(conta1.saldo);
        //Classe ContaPoupanca
        ContaPoupanca conta2 = new(2, "João", 1000.00m);
        //Calculando o rendimento antes de calcular o imposto, pois se não o fizer, o método CalcularImposto retornará o valor 0
        conta2.Rendimento(conta2.saldo);
        //Criação de uma lista para adicionar as respectivas contas criadas
        List<Conta> contas = new();
        //Adição das contas criadas
        contas.Add(conta1);
        contas.Add(conta2);
        // Apresentando o tipo de conta, o titular, o número da conta e o rendimento
        contas.ForEach(conta => Console.WriteLine($"O dono da conta, que é {conta.Name}(número : {conta.numero}), chama-se {conta.titular}. A conta possui rendimento de R${conta.rendimento:0.00} mensais"));
        //Demonstrando o valor do cálculo de imposto para cada conta
        Console.WriteLine($"A conta de número 1 pagará {conta1.CalcularImposto():0.00} de impostos");
        Console.WriteLine($"A conta de numero 2 pagará {conta2.CalcularImposto():0.00} de impostos");
    }
}
