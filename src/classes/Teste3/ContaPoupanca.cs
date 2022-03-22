namespace DesafioGFT_22_03_2022.src.classes.Teste3;
using DesafioGFT_22_03_2022.src.interfaces;
public class ContaPoupanca : Conta, IImposto
{
    //Construtor vazio
    public ContaPoupanca()
    {

    }
    //Construtor padrão para atribuir os valores aos atributos herdados da classe mãe(Conta)
    public ContaPoupanca(int numero, string titular, decimal saldo)
    {
        Name = "Conta Poupança";
        this.numero = numero;
        this.titular = titular;
        this.saldo = saldo;
    }
    // Método sobrescrito da classe mãe(Conta) para adequar à classe ContaPoupanca
    public override decimal Rendimento(decimal saldo)
    {
        decimal rendimento = saldo * 0.05m;
        this.rendimento = rendimento;
        return rendimento;
    }
    //Implementação do método oriundo da interface IImposto CalcularImposto
    public decimal CalcularImposto()
    {
        decimal imposto = this.rendimento * 0.1m;
        return imposto;
    }
}