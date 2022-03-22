namespace DesafioGFT_22_03_2022.src.classes.Teste3;

public class ContaPoupanca : Conta
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
        return rendimento;
    }
}