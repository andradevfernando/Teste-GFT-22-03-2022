namespace DesafioGFT_22_03_2022.src.classes.Teste3;
using DesafioGFT_22_03_2022.src.interfaces;

public class ContaCorrente : Conta, IImposto
{
    //Construtor vazio
    public ContaCorrente()
    {

    }
    //Construtor padrão para atribuir os valores aos atributos herdados da classe mãe(Conta)
    public ContaCorrente(int numero, string titular, decimal saldo)
    {
        Name = "Conta Corrente";
        this.numero = numero;
        this.titular = titular;
        this.saldo = saldo;
    }
    // Método sobrescrito da classe mãe(Conta) para adequar à classe ContaCorrente
    public override decimal Rendimento(decimal saldo)
    {
        decimal rendimento = saldo * 0.03m;
        this.rendimento = rendimento;
        return rendimento;
    }

    //Implementação do método oriundo da interface IImposto CalcularImposto
    public decimal CalcularImposto()
    {
        decimal imposto = this.rendimento * 0.25m;
        return imposto;
    }
}
