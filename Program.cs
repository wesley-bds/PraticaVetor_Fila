using System;


namespace PraticaVetor_Fila
{

    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila(); // Criando uma nova fila
            string opcao = ""; // Variavel para armazenar a opção do usuário

            //Loop do menu
            while (opcao.ToLower() != "q") //o ToLower para reconher tanto maiúsculas quanto minúsculas
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar fila");
                Console.WriteLine("3 - Atender cliente");
                Console.WriteLine("Q - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                // Verifica a opção escolhida
                if (opcao == "1")
                {
                    Cliente cliente = new Cliente();

                    Console.Write("Nome: ");
                    cliente.Nome = Console.ReadLine();

                    Console.Write("CPF: ");
                    cliente.CPF = Console.ReadLine();

                    Console.Write("Data de nascimento: ");
                    cliente.DataNascimento = Console.ReadLine();

                    Console.Write("É prioritário? (s/n): ");
                    string resp = Console.ReadLine();
                    if (resp.ToLower() == "s")
                    {
                        cliente.Prioritario = true;
                    }
                    else
                    {
                        cliente.Prioritario = false;
                    }

                    fila.AdicionarCliente(cliente);
                }
                else if (opcao == "2")
                {
                    fila.ListarFila();
                }
                else if (opcao == "3")
                {
                    fila.AtenderCliente();
                }
                else if (opcao.ToLower() == "q") 
                {
                    Console.WriteLine("Encerrando o programa...");
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
        }
    }
}