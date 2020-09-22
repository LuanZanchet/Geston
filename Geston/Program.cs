using Dados.Data;
using Geston.Forms;
using Geston.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geston
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConnection.OpenConnection();
            var list = new List<Type>();
            list.Add(new Cliente().GetType());
            list.Add(new Fornecedor().GetType());
            
            new SQLUtil().CreateDatabase(list);
            Application.Run(new ClienteForm());
        }

    }
}
