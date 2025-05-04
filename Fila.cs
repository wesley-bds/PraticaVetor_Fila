using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaVetor_Fila
{
    // classe Fila, que gerencia os clientes
    class Fila
    {
        private Cliente[] fila = new Cliente[10]; // Vetor que representa a fila com no máximo 10 posições
        private int fim = 0; // Controla a posição do último cliente na fila


        // Adiciona um cliente à fila
        public void AdicionarCliente(Cliente cliente)
        {
            if (fim >= 10)
            {
                Console.WriteLine("Fila cheia!"); // Verifica se há espaço
                return;
            }

            if (cliente.Prioritario)
            {
                // Encontra a posição onde o novo prioritário deve ser inserido
                int pos = 0;
                while (pos < fim && fila[pos].Prioritario)
                {
                    pos++; // Avança até o primeiro cliente não prioritario
                }

                // Move os clientes para abrir espaço para o novo prioritario
                for (int i = fim; i > pos; i--)
                {
                    fila[i] = fila[i - 1]; // Empurra o cliente uma posição para frente
                }

                // Insere o cliente prioritario na posição correta
                fila[pos] = cliente;
                Console.WriteLine("Cliente prioritário cadastrado com sucesso!");
            }
            else
            {
                // Adiciona o cliente comum no final da fila
                fila[fim] = cliente;
                Console.WriteLine("Cliente cadastrado com sucesso!");
            }

            fim++; // Atualiza a posição do final da fila
        }

        // Lista todos os clientes na fila
        public void ListarFila()
        {
            if (fim == 0)
            {
                Console.WriteLine("Fila vazia."); // Verifica se ha clientes
                return;
            }

            Console.WriteLine("\nFila de clientes:");
            for (int i = 0; i < fim; i++) // Garantir que exibira os clinetes cadastrados
            {
                Console.WriteLine($"{i + 1} - {fila[i]}"); // Exibe cada cliente com numeraçao
            }
        }

        // Atende (remove) o primeiro cliente da fila
        public void AtenderCliente()
        {
            if (fim == 0)
            {
                Console.WriteLine("Fila vazia."); // Se a fila estiver vazia, avisa
                return;
            }

            Console.WriteLine($"ATENDENDO CLIENTE: {fila[0]}"); // Mostra o cliente sendo atendido

            // Move os demais clientes uma posição à frente
            for (int i = 0; i < fim - 1; i++)
            {
                fila[i] = fila[i + 1];
            }

            fila[fim - 1] = null; // Remove referencia ao ultimo cliente

            fim--; // Diminui o tamanho da fila
        }
    }
}
