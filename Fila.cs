using System;


namespace PraticaVetor_Fila
{
    class Fila
    {
        private Cliente[] fila = new Cliente[10]; // Vetor para armazenar até 10 clientes

        private int fim = 0; // Variavel fim, controlar o número de clientes na fila


        
        public void AdicionarCliente(Cliente cliente)  // Metodo adicionar cliente, adc novo cliente na fila 
        {
            if (fim >= 10) // condição para verificar se a fila está cheia
            {
                Console.WriteLine("A fila está cheia!");
            }
            else
            {
                fila[fim] = cliente; // adc cliente novo no fim do vetor

                fim++; // Incrementa o número de clientes na fila

                Console.WriteLine("Cliente cadastrado com sucesso!");
            }
        }

        public void ListarFila() // Metodo listar fila, exibe todos os clientes na fila
        {
            if (fim == 0) // cond que ver se a fila esta vazia
            {
                Console.WriteLine("A fila está vazia.");
                return;
            }

            Console.WriteLine("Lista de clientes na fila:");

            
            for (int i = 0; i < fim; i++) // for ver quem é o prioritario
            {
                if (fila[i].Prioritario) 
                {
                    Console.Write((i + 1) + " - ");
                    fila[i].ExibirDados();
                }
                {
                    Console.Write((i + 1) + " - ");
                    fila[i].ExibirDados();
                }
            }

            // Depois mostra os não prioritários na ordem de chegada
            for (int i = 0; i < fim; i++)
            {
                if (!fila[i].Prioritario) // A diferença que tem o operador de negação (!) inrverte o valor bool
                {
                    Console.Write((i + 1) + " - ");
                    fila[i].ExibirDados();
                }
            }
        }

       
        public void AtenderCliente()  // Metodo atender, Atende o primeiro cliente prioritário. Se não houver, atende o primeiro da fila
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
                    break; // quando encontra sai do laço
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

            // Remove o cliente, deslocando os outros
            for (int i = atender; i < fim - 1; i++)
            {
                fila[i] = fila[i + 1];
            }

            fila[fim - 1] = null;

            fim--;
        }
    }
}