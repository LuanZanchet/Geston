using Geston.Dal;
using Geston.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geston.Forms
{
    public partial class ClienteForm : Form
    {
        Cliente Cliente = new Cliente();

        ClienteRepository ClienteRepository = new ClienteRepository();
        public ClienteForm()
        {
            InitializeComponent();
           ArredondaCantosdoForm();

        }
        protected void ArredondaCantosdoForm()
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Main().Show();
            
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            var source = new BindingSource();
            var clientes = ClienteRepository.GetAll();
            clientes.ForEach(n => n.Nome = n.ID + " - " + n.Nome);
            source.DataSource = clientes;
            viewCliente.DataSource = source;
            viewCliente.Columns[0].Visible = false;
            viewCliente.Columns[1].HeaderText = "Cliente:";
            viewCliente.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewCliente.Columns[2].HeaderText = "Telefone:";
            viewCliente.Columns[2].Width = 100;
            foreach (DataGridViewColumn item in viewCliente.Columns)
                if (item.Index != 1 && item.Index != 11) item.Visible = false;
            
        }

        private void viewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = 0;
            foreach (DataGridViewRow row in viewCliente.SelectedRows)
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
            SetClienteTela(id);
        }
        private void SetClienteTela(int Codigo)
        {
            Cliente = ClienteRepository.Get(Codigo);
            txtNome.Text = Cliente.Nome;
            txtTelefone.Text = Cliente.Telefone;
            txtBairro.Text = Cliente.Bairro;
            txtCelular.Text = Cliente.Celular;
            txtCep.Text = Cliente.Cep;
            txtCidade.Text = Cliente.Cidade;
            txtComplemento.Text = Cliente.Complemento;
            txtCpf.Text = Cliente.Cpf;
            txtNascimento.Text = Cliente.Nascimento;
            txtNumero.Text = Cliente.Numero;
            txtRua.Text = Cliente.Rua;
            txtTelefone.Text = Cliente.Telefone;
            txtUf.Text = Cliente.Uf;
            txtEmail.Text = "email@email.com";//Cliente.Email
        }

        private void iconADD_Click(object sender, EventArgs e)
        {
            new AddClienteForm().Show();
        }

        private void iconExcluir_Click(object sender, EventArgs e)
        {
            var id = 0;
            foreach (DataGridViewRow row in viewCliente.SelectedRows)
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
            ClienteRepository.Delete(Cliente);
        }
    }
}
