namespace DesafioGFT_22_03_2022.src.classes.Teste3;

public class ContaCorrente : Conta
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
        this.saldo -= 0.75m;
        return rendimento;
    }
}
