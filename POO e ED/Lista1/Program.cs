using System;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        { 

            string x = "0";
            string y;
            float z;
            int q;

            Lista<Lista<float>> listadelista = new Lista<Lista<float>>(); //guarda uma lista de listas de float
            Lista<Fila<float>> listadefila = new Lista<Fila<float>>(); //guarda uma lista de filas de float
            Lista<Pilha<float>> listadepilha = new Lista<Pilha<float>>(); //guarda uma lista de pilhas de float


           while (x != "4")
            {
                y = "0";
                Console.WriteLine("[1]: Criar uma lista de números reais;");
                Console.WriteLine("[2]: Criar uma fila de números reais;");
                Console.WriteLine("[3]: Criar uma pilha de números reais;");
                Console.WriteLine("[4]: SAIR");
                x = Console.ReadLine();
                switch (x)
                {

                    case "1":

                        Lista<float> lista = new Lista<float>(); //cria uma no lista generica

                        while (y != "6")
                        {
                            
                            Console.WriteLine("------------------MENU DE LISTA--------------------");
                            Console.WriteLine("[1]: Adicionar um elemento da lista no inicio;");
                            Console.WriteLine("[2]: Adicionar um elemento da lista no fim;");
                            Console.WriteLine("[3]: Remover um elemento especifico da lista;");
                            Console.WriteLine("[4]: Imprimir a lista da esquerda para a direita;");
                            Console.WriteLine("[5]: Imprimir a lista da direita para a esquerda");
                            Console.WriteLine("[6]: SAIR e finalizar lista atual");
                            y = Console.ReadLine();

                            switch (y)
                            {

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

                                case "1":
                                    Console.WriteLine();
                                    Console.WriteLine("Digite um numero para inserir no inicio");
                                    z = float.Parse(Console.ReadLine());
                                    lista.insereInicio(z);
                                    break;
                                case "2":
                                    Console.WriteLine();
                                    Console.WriteLine("Digite um numero para inserir no final");
                                    z = float.Parse(Console.ReadLine());
                                    lista.insereFim(z);
                                    break;
                                case "3":
                                    Console.WriteLine();
                                    Console.WriteLine("Digite um numero para ser removido");
                                    z = float.Parse(Console.ReadLine());
                                    lista.Remove(z);
                                    break;
                                case "4":
                                    Console.WriteLine();
                                    Console.WriteLine("Imprimindo lista E -> D");
                                    lista.imprimeListaE();
                                    Console.WriteLine();
                                    break;
                                case "5":
                                    Console.WriteLine();
                                    Console.WriteLine("Imprimindo lista D -> E");
                                    lista.imprimeListaD();
                                    Console.WriteLine();
                                    break;

                                case "6":
                                    Console.WriteLine(" Voltando ao menu principal");
                                    listadelista.insereFim(lista);                                   
                                    break;

                                default:
                                    Console.WriteLine("Entrada Inválida:");
                                    break;

                            } 
                        }
                        Console.WriteLine("-----------------------------------------------------------");
                        break;

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

                    case "2":
                        Fila<float> fila = new Fila<float>(); //cria fila generica

                        while (y != "4")
                        {
                            Console.WriteLine("------------------MENU DE FILA--------------------");
                            Console.WriteLine("[1]: Adicionar um elemento da fila;");
                            Console.WriteLine("[2]: Remover um elemento da fila;");
                            Console.WriteLine("[3]: Imprimir a fila");
                            Console.WriteLine("[4]: SAIR e finalizar fila atual");
                            y = Console.ReadLine();

                            switch (y)
                            {
                                case "1":
                                    Console.WriteLine();
                                    Console.WriteLine("Digite um numero para inserir na fila");
                                    z = float.Parse(Console.ReadLine());
                                    fila.insereFila(z);
                                    break;
                                case "2":
                                    Console.WriteLine();
                                    Console.WriteLine("Remove o primeiro elemento da fila");
                                    fila.removeFila();
                                    break;
                                case "3":
                                    Console.WriteLine();
                                    Console.WriteLine("Imprimindo fila");
                                    fila.imprimeFila();
                                    Console.WriteLine();
                                    break;
                                case "4":
                                    Console.WriteLine(" Voltando ao menu principal");
                                    listadefila.insereFim(fila);
                                    break;
                                default:
                                    Console.WriteLine("Entrada Inválida:");
                                    break;
                            }
                        }

                        Console.WriteLine("-----------------------------------------------------------");
                        break;

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

                    case "3":
                        Pilha<float> pilha = new Pilha<float>(); //cria fila generica

                        while (y != "4")
                        {
                            Console.WriteLine("------------------MENU DE FILA--------------------");
                            Console.WriteLine("[1]: Adicionar um elemento da pilha;");
                            Console.WriteLine("[2]: Remover um elemento da pilha;");
                            Console.WriteLine("[3]: Imprimir a pilha");
                            Console.WriteLine("[4]: SAIR e finalizar pilha atual");
                            y = Console.ReadLine();

                            switch (y)
                            {
                                case "1":
                                    Console.WriteLine();
                                    Console.WriteLine("Digite um numero para inserir na pilha");
                                    z = float.Parse(Console.ReadLine());
                                    pilha.inserePilha(z);
                                    break;
                                case "2":
                                    Console.WriteLine();
                                    Console.WriteLine("Remove o topo da pilha");
                                    pilha.removePilha();
                                    break;
                                case "3":
                                    Console.WriteLine();
                                    Console.WriteLine("Imprimindo pilha");
                                    pilha.imprimePilha();
                                    Console.WriteLine();
                                    break;
                                case "4":
                                    Console.WriteLine(" Voltando ao menu principal");
                                    listadepilha.insereFim(pilha);
                                    break;
                                default:
                                    Console.WriteLine("Entrada Inválida:");
                                    break;
                            }
                        }

                        Console.WriteLine("-----------------------------------------------------------");
                        break;

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

                    case "4":
                        Console.WriteLine("Imprimindo dados utilizados");

                        //imprimindo listas

                        Console.WriteLine("LISTAS");
                        q = 0;
                        if (listadelista.estaVazia())
                        {
                            Console.WriteLine("Não foi criada nenhuma lista");
                        }
                        else
                        {
                            Noh<Lista<float>> temp = listadelista.getI();
                            while (temp != null)
                            {
                                q++;
                                Console.WriteLine("Lista " + q + ":");
                                (temp.getData()).imprimeListaE();
                                Console.WriteLine();
                                temp = temp.getNext();

                            }
                        }

                        //imprimindo filas

                        Console.WriteLine("FILAS");
                        q = 0;
                        if (listadefila.estaVazia())
                        {
                            Console.WriteLine("Não foi criada nenhuma fila");
                        }
                        else
                        {
                            Noh<Fila<float>> temp = listadefila.getI();
                            while (temp != null)
                            {
                                q++;
                                Console.WriteLine("Fila " + q + ":");
                                (temp.getData()).imprimeFila();
                                Console.WriteLine();
                                temp = temp.getNext();

                            }
                        }

                        //imprimindo as pilhas

                        Console.WriteLine("PILHAS");
                        q = 0;
                        if (listadepilha.estaVazia())
                        {
                            Console.WriteLine("Não foi criada nenhuma pilha");
                        }
                        else
                        {
                            Noh<Pilha<float>> temp = listadepilha.getI();
                            while (temp != null)
                            {
                                q++;
                                Console.WriteLine("Pilha " + q + ":");
                                (temp.getData()).imprimePilha();
                                Console.WriteLine();
                                temp = temp.getNext();

                            }
                        }


                        Console.WriteLine("SAIR");
                        break;


                    default:
                        Console.WriteLine("Entrada Inválida:");
                        break;
                }
                
            }
        }
    }
}
