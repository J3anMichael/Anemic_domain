using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Enriquecendo um modelo anemico 


namespace Modelo_anemico
{
    internal sealed class Cliente // sealed para que o dominio não possa ser herdado
    {
        // Setters privados para que não possa ser alterado em outro arquivo
        public int Id { get; private set; } 
        public string Nome { get; private set; }
        public string Endereco { get; private set; }


        // Construtor
        public Cliente(int id, string nome, string endereco)
        {
            Validar(id, nome, endereco);
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        // Definindo comportamentos da aplicação
        public void Update(int id, string nome, string endereco)
        {
            Validar(id, nome, endereco);
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }


        // Validacoes
        private void Validar(int id, string nome, string endereco)
        {
            if (id < 0)
                throw new ArgumentException("O id tem que ser maior que 0");

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
                throw new InvalidOperationException("O nome é requerido");

            if (nome.Length < 3)
                throw new ArgumentException("O nome deve ter no mínimo 3 caracteres");

            if (nome.Length > 100)
                throw new ArgumentException("O nome excedeu 100 caracteres");

            
        }
    }


    
}
