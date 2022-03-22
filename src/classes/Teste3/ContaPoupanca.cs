namespace DesafioGFT_22_03_2022.src.classes.Teste3;
using DesafioGFT_22_03_2022.src.interfaces;
public class ContaPoupanca : Conta, IImposto
{
    public ContaPoupanca()
    {

    }
    public ContaPoupanca(int numero, string titular, decimal saldo)
    {
        Name = "Conta Poupança";
        this.numero = numero;
        this.titular = titular;
        this.saldo = saldo;
    }
    public override decimal Rendimento(decimal saldo)
    {
        decimal rendimento = saldo * 0.05m;
        this.rendimento = rendimento;
        return rendimento;
    }
    public decimal CalcularImposto()
    {
        decimal imposto = this.rendimento * 0.25m;
        return imposto;
    }
}