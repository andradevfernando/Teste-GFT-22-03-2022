namespace DesafioGFT_22_03_2022.src.classes.Teste2;
public class Pessoa
{
    public string nome { get; set; }
    public string endereco { get; set; }
    public double telefone { get; set; }

    public Pessoa()
    {

    }
    public Pessoa(string nome, string endereco, double telefone)
    {
        this.nome = nome;
        this.endereco = endereco;
        this.telefone = telefone;
    }
}