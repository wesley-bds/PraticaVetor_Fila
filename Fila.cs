using System;


namespace PraticaVetor_Fila
{
    class Fila
    {
        private Cliente[] fila = new Cliente[10]; // Vetor para armazenar até 10 clientes

        private int fim = 0; // Controlar o número de clientes na fila


        // Adiciona um novo cliente à fila
        public void AdicionarCliente(Cliente cliente)
        {
            if (fim >= 10)
            {
                Console.WriteLine("A fila está cheia!");
            }
            else
            {
                fila[fim] = cliente;
                fim++;
                Console.WriteLine("Cliente cadastrado com sucesso!");
            }
        }

        public void ListarFila()
        {
            if (fim == 0)
            {
                Console.WriteLine("A fila está vazia.");
                return;
            }

            Console.WriteLine("Lista de clientes na fila:");

            // Primeiro mostra os prioritários na ordem de chegada
            for (int i = 0; i < fim; i++)
            {
                if (fila[i].Prioritario)
                {
                    Console.Write((i + 1) + " - ");
                    fila[i].ExibirDados();
                }
            }

            // Depois mostra os não prioritários na ordem de chegada
            for (int i = 0; i < fim; i++)
            {
                if (!fila[i].Prioritario)
                {
                    Console.Write((i + 1) + " - ");
                    fila[i].ExibirDados();
                }
            }
        }

        // Atende o primeiro cliente prioritário. Se não houver, atende o primeiro da fila
        public void AtenderCliente()
        {
            if (fim == 0)
            {
                Console.WriteLine("A fila está vazia.");
                return;
            }

            int Prioritario = -1;

            // Procura o primeiro cliente prioritário

            for (int i = 0; i < fim; i++)
            {
                if (fila[i].Prioritario)
                {
                    Prioritario = i;
                    break;
                }
            }

            // Define quem será atendido
            int atender = 0;
            if (Prioritario != -1)
            {
                atender = Prioritario;
            }

            // Exibe os dados do cliente atendido
            Console.WriteLine("ATENDENDO CLIENTE:");
            fila[atender].ExibirDados();

            // Remove o cliente atendido da fila, deslocando os outros
            for (int i = atender; i < fim - 1; i++)
            {
                fila[i] = fila[i + 1];
            }

            fila[fim - 1] = null;

            fim--;
        }
    }
}