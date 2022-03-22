namespace DesafioGFT_22_03_2022.src.classes.Teste2;
public class Pessoa
{
    // gets e setters dos atributos da classe
    public string nome { get; set; }
    public string endereco { get; set; }
    public double telefone { get; set; }

    // Construtor vazio
    public Pessoa()
    {

    }

    // Construtor que atribui os valores aos atributos
    public Pessoa(string nome, string endereco, double telefone)
    {
        this.nome = nome;
        this.endereco = endereco;
        this.telefone = telefone;
    }
}