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
        Choose();
    }
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
    static void Choose()
    {
        Menu();
        string choose = Console.ReadLine();

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
