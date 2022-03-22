namespace DesafioGFT_22_03_2022.src.classes.Teste3;

public abstract class Conta
{
    public decimal rendimento { get; set; }
    public string Name { get; set; }
    public int numero { get; set; }
    public string? titular { get; set; }
    public decimal saldo { get; set; }
    public Conta()
    {

    }
    public Conta(int numero, string titular, decimal saldo)
    {
        this.numero = numero;
        this.titular = titular;
        this.saldo = saldo;
    }
    public virtual decimal Rendimento(decimal saldo)
    {
        return saldo;
    }

}