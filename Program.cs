using ContaBancaria.Model;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;

            Conta c1 = new Conta(1, 123, 1, "Gaspar", 100000000.0M);

            c1.Visualizar();
            c1.SetNumero(345);
            c1.Visualizar();

            c1.Sacar(1000);

            c1.Visualizar();

            c1.Depositar(5000);

            c1.Visualizar();


            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("                 |%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%|");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |                           Banco do Br                            |");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&|");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |                 1 - Criar Conta                                  |");
                Console.WriteLine("                 |                 2 - Listar Todas as contas                       |");
                Console.WriteLine("                 |                 3 - Buscar conta por número                      |");
                Console.WriteLine("                 |                 4 - Atualizar dados da conta                     |");
                Console.WriteLine("                 |                 5 - Apagar conta                                 |");
                Console.WriteLine("                 |                 6 - Sacar                                        |");
                Console.WriteLine("                 |                 7 - Depositar                                    |");
                Console.WriteLine("                 |                 8 - Transferir Valores Entre Contas              |");
                Console.WriteLine("                 |                 9 - Sair                                         |");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%|");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |                Entre com a opção desejada                        |");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%|");
                opcao = Convert.ToInt32(Console.ReadLine());
              
            
                switch (opcao)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9: 
                        {
                            Console.WriteLine("Obrigado por utilizar o nosso banco!!");
                            System.Environment.Exit(0);
                        }

                        break;

                    default:
                        Console.WriteLine("Essa opção não existe!");

                        break;
                }


            } while (true);


        }
    }
}