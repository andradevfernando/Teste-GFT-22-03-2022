namespace DesafioGFT_22_03_2022.src.classes.Teste3;
using DesafioGFT_22_03_2022.src.interfaces;

public class ContaCorrente : Conta, IImposto
{
    public ContaCorrente()
    {

    }
    public ContaCorrente(int numero, string titular, decimal saldo)
    {
        Name = "Conta Corrente";
        this.numero = numero;
        this.titular = titular;
        this.saldo = saldo;
    }
    public override decimal Rendimento(decimal saldo)
    {
        decimal rendimento = saldo * 0.03m;
        this.rendimento = rendimento;
        return rendimento;
    }
    public decimal CalcularImposto()
    {
        decimal imposto = this.rendimento * 0.1m;
        return imposto;
    }
}
