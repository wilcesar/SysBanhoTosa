using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models.Classes
{
    class Cliente
    {
        private int id;
        private string nome;
        private string telefone;
        private Endereco endereco;
        private string email;
        private string situacao;
        
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Telefone
        {
            get => telefone;
            set => telefone = value;
        }
        public Endereco Endereco
        {
            get => endereco;
            set => endereco = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Situacao { 
            get => situacao; 
            set => situacao = value; }
    }
}
