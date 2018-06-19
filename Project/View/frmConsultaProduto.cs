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
    public partial class frmConsultaProduto : Form
    {
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            txtDescricao.Enabled = false;
            txtValorProduto.Enabled = false;
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Insira o código do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Produto p = new Produto();
                p = ProdutoDAO.ObterProdutoPorId(int.Parse(txtId.Text));
                if (p == null)
                {
                    MessageBox.Show("Produto não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtDescricao.Text = p.Descricao;
                    txtValorProduto.Text = p.Valor.ToString();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Insira o código do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btnSalvar.Enabled = true;
                txtDescricao.Enabled = true;
                txtDescricao.ReadOnly = false;
                txtValorProduto.Enabled = true;
                txtValorProduto.ReadOnly = false;
                btnEditar.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Insira o código do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!txtDescricao.Text.Equals("") && !txtValorProduto.Text.Equals(""))
                {
                    Produto produto = new Produto();
                    produto = ProdutoDAO.ObterProdutoPorId(int.Parse(txtId.Text));
                    produto.Descricao = txtDescricao.Text;
                    produto.Valor = (float.Parse(txtValorProduto.Text));
                    DialogResult result = MessageBox.Show("Deseja salvar as alterações? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (ProdutoDAO.Alterar(produto))
                        {
                            MessageBox.Show("Produto alterado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDescricao.Enabled = false;
                            txtValorProduto.Enabled = false;
                            btnSalvar.Enabled = false;
                            btnEditar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Erro durante a operação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Todos os campos são de preenchimento obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
       

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtDescricao.Clear();
            txtValorProduto.Clear();
            txtId.Focus();
        }

    }
}
