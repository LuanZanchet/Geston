using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Data
{
    public class TableAttribute : Attribute
    {
        public string Name;
        public TableAttribute(string Name)
        {
            this.Name = Name;
        }
    }
}
