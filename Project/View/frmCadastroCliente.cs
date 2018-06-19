using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DAO;
using Project.Model;

namespace Project
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mskCpf.Text))
            {
                MessageBox.Show("Campo cpf é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Campo nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(mskTel.Text))
            {
                MessageBox.Show("Campo telefone é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Campo endereço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (string.IsNullOrWhiteSpace(txtComplemento.Text))
            {
                MessageBox.Show("Campo complemento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("Campo bairro é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                MessageBox.Show("Campo cidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                Cliente cliente = new Cliente();
                cliente.Cpf = mskCpf.Text;
                cliente.Nome = txtNomeCliente.Text;
                cliente.Telefone = mskTel.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Complemento = txtComplemento.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Cidade = txtCidade.Text;

                if (ClienteDAO.ObterClientePorCpf(cliente.Cpf) == null)
                {
                    if (ClienteDAO.Incluir(cliente))
                    {
                        cliente = ClienteDAO.ObterClientePorCpf(cliente.Cpf);
                        txtId.Text = cliente.Id.ToString();
                        MessageBox.Show(" Cliente nº" + txtId.Text + " cadastrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtId.Clear();
                        mskCpf.Clear();
                        txtNomeCliente.Clear();
                        mskTel.Clear();
                        txtEndereco.Clear();
                        txtComplemento.Clear();
                        txtBairro.Clear();
                        txtCidade.Clear();
                        txtNomeCliente.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao tentar incluir o cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cpf já cadastrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            mskCpf.Clear();
            txtNomeCliente.Clear();
            mskTel.Clear();
            txtEndereco.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtNomeCliente.Focus();
        }

    }
}
