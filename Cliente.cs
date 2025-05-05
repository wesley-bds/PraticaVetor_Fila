using System;


namespace PraticaVetor_Fila
{
    // Herança Cliente de Pessoa
    class Cliente : Pessoa
    {
        public bool Prioritario;

        public void ExibirDados()
        {
            Console.Write("NOME: " + Nome);
            Console.Write(", CPF: " + CPF);
            Console.Write(", NASCIMENTO: " + DataNascimento);
            Console.Write(", Prioritário: ");

            if (Prioritario)
            {
                Console.WriteLine("Sim");
            }
            else
            {
                Console.WriteLine("Não");
            }
        }
    }

}
