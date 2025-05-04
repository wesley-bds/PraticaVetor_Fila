using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaVetor_Fila
{
    // Classe que representa um cliente
    class Cliente
    {
        // Propriedades para armazenar os dados do cliente (NOME,CPF,DATANASCIMENTO)
        public string Nome { get; set; }

       
        public string CPF { get; set; }

       
        public string DataNascimento { get; set; }

        // Propriedade booleana para indicar se o cliente é prioritario
        public bool Prioritario { get; set; }

        // Metodo ToString para exibir as informações do cliente de forma formatada
        public override string ToString()
        {
            return $"NOME: {Nome}, CPF: {CPF}, NASCIMENTO: {DataNascimento}, Prioritário: {(Prioritario ? "Sim" : "Não")}";
        }
    }

}
