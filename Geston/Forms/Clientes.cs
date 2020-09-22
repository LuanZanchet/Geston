using Geston.Dal;
using Geston.Model;
using System;
using System.Windows.Forms;

namespace Geston
{
    public partial class Form1 : Form
    {
        ClienteRepository dal = new ClienteRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void InserirCliente()
        {
            var cliente = new Cliente();
            cliente.Nome = descricao.Text;
            cliente.Telefone = "(55) 9999-9999";
            cliente.Cpf = "272.472.050-40";
            cliente.Celular = "(55) 9999-9999";
            cliente.Nascimento = "01/01/2000";
            cliente.Numero = "0";
            cliente.Rua = "Rua Dos Bobos";
            cliente.Uf = "SP";
            cliente.Complemento = "Apto 0";
            cliente.Cidade = "São Paulo";
            cliente.Cep = "89999-999";
            cliente.Bairro = "Centro";
            cliente.Email = "Email@Email.com";

            var a = dal.Inserir(cliente);
       
            MessageBox.Show("Cliente inserido com o ID: "+a.ToString());
           
        }
        private void BuscarCliente(int Codigo)
        {
            var c = dal.Get(Codigo);
            if(c == null)
            {
                MessageBox.Show("Cujo não encontrado");
                return;
            }
            MessageBox.Show("Nome do Cujo: " +c.Nome.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InserirCliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarCliente(Convert.ToInt32(id.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var c = dal.GetAll();
            var tex = "";
            c.ForEach(a => tex +=  "Cliente :" + a.ID + " " + a.Nome + "\n");
            MessageBox.Show(tex);
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.ID = Convert.ToInt32(txt_atualizar.Text);
            cliente.Nome = txt_descricaoat.Text;
            dal.Atualizar(cliente);
            MessageBox.Show($"Cliente {Convert.ToInt64(txt_atualizar.Text)} atualizado com sucesso");
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.ID = Convert.ToInt32(txt_deletar.Text);
            dal.Deletar(cliente);
            MessageBox.Show($"Cliente {Convert.ToInt64(txt_deletar.Text)} deletado com sucesso");
        }
    }
}
