﻿using Geston.Dal;
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
    public partial class AddClienteForm : Form
    {

        ClienteRepository ClienteRepository = new ClienteRepository();
        public AddClienteForm()
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
          
            
        }

        private void SetClienteTela(int Codigo)
        {
            var Cliente = ClienteRepository.Get(Codigo);
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

        private void iconSalvar_Click(object sender, EventArgs e)
        {
        
            ClienteRepository.Insert(GetDadosTela());
        }

        private Cliente GetDadosTela()
        {
            var Cliente = new Cliente();
            Cliente.Email = txtEmail.Text;
            Cliente.Bairro = txtBairro.Text;
            Cliente.Celular = txtCelular.Text;
            Cliente.Cep = txtCep.Text;
            Cliente.Cidade = txtCidade.Text;
            Cliente.Complemento = txtComplemento.Text;
            Cliente.Cpf = txtCpf.Text;
            Cliente.Email = txtEmail.Text;
            Cliente.Nascimento = txtNascimento.Text;
            Cliente.Nome= txtNome.Text;
            Cliente.Numero = txtNumero.Text;
            Cliente.Rua = txtRua.Text;
            Cliente.Telefone = txtTelefone.Text;
            Cliente.Uf = txtUf.Text;
            return Cliente;
        }
    }
}
