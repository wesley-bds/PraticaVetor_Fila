using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaVetor_Fila
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila(); // Cria a fila

            string opcao = ""; // Variável para armazenar a opção do usuário

            while (true) // Laço principal do menu
            {
                // Exibe o menu de opções
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar fila");
                Console.WriteLine("3 - Atender cliente");
                Console.WriteLine("q - SAIR");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine().Trim(); // Lê e limpa a entrada do usuário

                // Verifica se o usuário quer sair (q ou Q)
                if (opcao.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Saindo...");
                    break; // Encerra o loop
                }

                // Verifica qual ação executar
                if (opcao == "1")
                {
                    // Criação e preenchimento do cliente
                    Cliente cliente = new Cliente();

                    Console.Write("Digite o nome completo do cliente: ");
                    cliente.Nome = Console.ReadLine();

                    Console.Write("Digite o CPF do cliente: ");
                    cliente.CPF = Console.ReadLine();

                    Console.Write("Digite a data de nascimento do cliente (dd/mm/aaaa): ");
                    cliente.DataNascimento = Console.ReadLine();

                    Console.Write("O cliente é prioritário? (s/n): ");
                    cliente.Prioritario = Console.ReadLine().Trim().ToLower() == "s";

                    fila.AdicionarCliente(cliente); // Adiciona cliente na fila
                }
                else if (opcao == "2")
                {
                    fila.ListarFila(); // Lista os clientes na fila
                }
                else if (opcao == "3")
                {
                    fila.AtenderCliente(); // Atende (remove) o primeiro cliente
                }
                else
                {
                    Console.WriteLine("Opção inválida."); // Se a opção for desconhecida
                }
            }
        }
    }
}
