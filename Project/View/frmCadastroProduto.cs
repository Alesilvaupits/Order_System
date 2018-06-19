using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Model;
using Project.DAO;

namespace Project
{
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtDescricao.Clear();
            txtValorProduto.Clear();
            txtId.Focus();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!txtDescricao.Text.Equals("") && !txtValorProduto.Text.Equals(""))
            {
                Produto produto = new Produto();
                produto.Descricao = txtDescricao.Text;
                produto.Valor = float.Parse(txtValorProduto.Text);
                if (ProdutoDAO.ObterProdutoPorId(produto.Id) == null)
                {
                    if (ProdutoDAO.Incluir(produto))
                    {
                        produto = ProdutoDAO.ObterProdutoPorId(produto.Id);
                        txtId.Text = produto.Id.ToString();
                        MessageBox.Show("Produto nº" + txtId.Text + " cadastrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtId.Clear();
                        txtDescricao.Clear();
                        txtValorProduto.Clear();                      
                    }
                    else
                    {
                        MessageBox.Show("Erro ao tentar incluir o produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
      
            }
            else
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           }
        }
    }
    
