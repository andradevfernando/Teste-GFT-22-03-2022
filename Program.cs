using DesafioGFT_22_03_2022.src.classes.Teste1;
using DesafioGFT_22_03_2022.src.classes.Teste2;
using DesafioGFT_22_03_2022.src.classes.Teste3;
using DesafioGFT_22_03_2022.src.classes.Teste4;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //Inicializando o método Choose
        Choose();
    }
    //Criação de um menu onde o usuário tera a informação visual de qual teste ele pode escolher e qual input deve utilizar para acessar tal teste
    static void Menu()
    {
        {
            Console.WriteLine(@$"
Welcome, choose your option
1- Teste1
2- Teste2
3- Teste3
4- Teste4
X- Sair");
        }
    }
    //Método Choose(escolher) onde o usuário terá 5 opções, o Teste 1, 2, 3 , 4 e uma opção para finalizar
    static void Choose()
    {
        Menu();
        //Lendo a entrada do usuário
        string choose = Console.ReadLine();

        //Realizando um loop para que o usuário sempre tenha a opção de escolher até o mesmo finalizar o código com o input da letra "x" maiúscula ou minúscula
        while (choose != "X".ToUpper())
        {
            switch (choose)
            {
                case "1":
                    Teste1.Teste();
                    break;
                case "2":
                    Teste2.Teste();
                    break;
                case "3":
                    Teste3.Teste();
                    break;
                case "4":
                    Teste4.Teste();
                    break;
                default:
                    Console.WriteLine("Dígito errado, tente novamente");
                    break;
            }
            Menu();
            choose = Console.ReadLine().ToUpper();
        }
    }
}
