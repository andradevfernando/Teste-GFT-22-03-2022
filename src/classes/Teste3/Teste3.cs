namespace DesafioGFT_22_03_2022.src.classes.Teste3;
using DesafioGFT_22_03_2022.src.interfaces;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
public class Teste3
{
    public static void Teste()
    {
        ContaCorrente conta1 = new(1, "Carlos", 1000.00m);
        conta1.Rendimento(conta1.saldo);
        ContaPoupanca conta2 = new(2, "João", 1000.00m);
        conta2.Rendimento(conta2.saldo);

        List<Conta> lista = new();
        lista.Add(conta1);
        lista.Add(conta2);
        lista.ForEach(conta => Console.WriteLine($"O dono da conta, que é {conta.Name}(número : {conta.numero}), chama-se {conta.titular}, possui rendimento de R${conta.rendimento} mensais e pagará "));
        Console.WriteLine($"A conta 1 pagará {conta1.CalcularImposto():0.00} de impostos");
        Console.WriteLine($"A conta 2 pagará {conta2.CalcularImposto():0.00} de impostos");


    }
}
