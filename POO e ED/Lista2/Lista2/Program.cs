using System;

namespace Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "0";
            int y;
            ArvoreBin arvoreBin = new ArvoreBin();
            
           

            while (x != "4")
            {
                Console.WriteLine("------------------MENU-------------------");
                Console.WriteLine("[1]: Inserir Inteiro na Arvore Binaria;");
                Console.WriteLine("[2]: Remover Inteiro na Arvore Binaria;");
                Console.WriteLine("[3]: Imprimir Arvore Binaria;");
                Console.WriteLine("[4]: SAIR");
                x = Console.ReadLine();
                switch (x)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Digite um numero para inserir na árvore");
                        y = int.Parse(Console.ReadLine());
                        arvoreBin.inserir(y);
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Remove o inteiro da árvore");
                        y = int.Parse(Console.ReadLine());
                        arvoreBin.remover(y);
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Imprimindo árvore");
                        arvoreBin.imprimirArvore();
                        break;
                    case "4":
                        Console.WriteLine();
                        Console.WriteLine("SAIR");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Entrada Inválida:");
                        break;
                }
            }
        }
    }
}

