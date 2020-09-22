using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geston.Model
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Nascimento { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}