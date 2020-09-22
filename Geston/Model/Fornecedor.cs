using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geston.Model
{
    public class Fornecedor
    {
        [Key]
        public int ID { get; set; }
        public string Descricao { get; set; }
    }
}
