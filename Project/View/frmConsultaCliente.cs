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
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            txtNomeCliente.Enabled = false;
            mskTel.Enabled = false;
            txtEndereco.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;      
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Insira o código do cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cliente c = new Cliente();
                c = ClienteDAO.ObterClientePorId(int.Parse(txtId.Text));
                if (c == null)
                {
                    MessageBox.Show("Cliente não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mskCpf.Text = c.Cpf;
                    txtNomeCliente.Text = c.Nome;
                    mskTel.Text = c.Telefone;
                    txtEndereco.Text = c.Endereco;
                    txtComplemento.Text = c.Complemento;
                    txtBairro.Text = c.Bairro;
                    txtCidade.Text = c.Cidade;
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Insira o código do cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btnSalvar.Enabled = true;
                txtNomeCliente.Enabled = true;
                txtNomeCliente.ReadOnly = false;
                mskTel.Enabled = true;
                mskTel.ReadOnly = false;
                txtEndereco.Enabled = true;
                txtEndereco.ReadOnly = false;
                txtComplemento.Enabled = true;
                txtComplemento.ReadOnly = false;
                txtBairro.Enabled = true;
                txtBairro.ReadOnly = false;
                txtCidade.Enabled = true;
                txtCidade.ReadOnly = false;
                btnEditar.Enabled = false;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(mskCpf.Text))
            {
                MessageBox.Show("Insira o código do cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                {
                    MessageBox.Show("Campo nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(mskTel.Text)) 
                {
                    MessageBox.Show("Campo telefone é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(txtEndereco.Text))
                {
                    MessageBox.Show("Campo endereço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(txtComplemento.Text))
                {
                    MessageBox.Show("Campo complemento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(txtBairro.Text))
                {
                    MessageBox.Show("Campo bairro é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(txtCidade.Text))
                {
                    MessageBox.Show("Campo cidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Cliente cliente = new Cliente();
                    cliente = ClienteDAO.ObterClientePorId(int.Parse(txtId.Text));
                    cliente.Cpf = mskCpf.Text;
                    cliente.Nome = txtNomeCliente.Text;
                    cliente.Telefone = mskTel.Text;
                    cliente.Endereco = txtEndereco.Text;
                    cliente.Complemento = txtComplemento.Text;
                    cliente.Bairro = txtBairro.Text;
                    cliente.Cidade = txtCidade.Text;
                    DialogResult result = MessageBox.Show("Deseja salvar as alterações?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (ClienteDAO.Alterar(cliente))
                        {
                            MessageBox.Show("Cliente alterado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNomeCliente.Enabled = false;
                            mskTel.Enabled = false;
                            txtEndereco.Enabled = false;
                            txtComplemento.Enabled = false;
                            txtBairro.Enabled = false;
                            txtCidade.Enabled = false;
                            btnSalvar.Enabled = false;
                            btnEditar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Erro durante a operação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            
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
            txtId.Focus();
        }

    }
}


