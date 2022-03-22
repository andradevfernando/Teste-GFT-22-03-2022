namespace DesafioGFT_22_03_2022.src.classes.Teste3;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
public class Teste3
{
    public static void Teste()
    {
        ContaCorrente contaCorrente = new(1, "Carlos", 1000.00m);
        ContaPoupanca contaPoupanca = new(2, "João", 1000.00m);

        List<Conta> lista = new();
        lista.Add(contaCorrente);
        lista.Add(contaPoupanca);


        foreach (var conta in lista)
            Console.WriteLine($"O dono da conta, que é {conta.Name}(número : {conta.numero}), chama-se {conta.titular}, possui rendimento de R${conta.Rendimento(conta.saldo).ToString("0.00")} mensais");


    }
}
