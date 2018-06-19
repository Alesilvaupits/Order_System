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
using Project.View;

namespace Project
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnCadCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente form = new frmCadastroCliente();
            form.ShowDialog();
        }

        private void mnCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario form = new frmCadastroFuncionario();
            form.ShowDialog();
        }

        private void mnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto form = new frmCadastroProduto();
            form.ShowDialog();
        }

        private void btnIncluirPedido_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodFuncionario.Text))
            {
                MessageBox.Show("Insira o código do funcionário");
            }
            if (string.IsNullOrWhiteSpace(txtCodCliente.Text))
            {
                MessageBox.Show("Insira o código do cliente");
            }   
            else
            {
                Pedido pedido = new Pedido();
                Produto produto = new Produto();
                List<Produto> produtos = new List<Produto>();
                foreach (var item in lboProdutos.Items)
                {
                    produto = ProdutoDAO.ObterProdutoPorNome(item.ToString());
                    produtos.Add(produto);
                }
                pedido.Produtos = produtos;
                
                if (string.IsNullOrWhiteSpace(txtFuncionario.Text))
                {
                    MessageBox.Show("Insira um funcionário válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pedido.Funcionario = FuncionarioDAO.ObterFuncionarioPorId(int.Parse(txtCodFuncionario.Text));
                    pedido.Cliente = ClienteDAO.ObterClientePorId(int.Parse(txtCodCliente.Text));
                    if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                    {
                        MessageBox.Show("Insira um cliente válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        pedido.Data = DateTime.Now;
                        // txtId.Text = pedido.Id.ToString();

                        if (lboProdutos.Items.Count <= 0)
                        {
                            MessageBox.Show("Insira um produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            pedido.TotalAPagar = float.Parse(txtTotalAPagar.Text);
                            pedido.Obs = txtObservacoes.Text;
                            pedido.Status = "Em andamento";
                            pedido.DataEnc = DateTime.Now;

                            DialogResult r = MessageBox.Show("Tem certeza que deseja incluir este pedido?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (r == DialogResult.Yes)
                            {
                                if (PedidoDAO.Incluir(pedido))
                                {
                                    txtId.Text = pedido.Id.ToString();
                                    MessageBox.Show("Pedido nº " + txtId.Text + " incluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                                    foreach(Produto x in produtos)
                                    {
                                        x.Pedidos.Add(pedido);
                                        ProdutoDAO.Alterar(x);
                                    }
                                    txtCodFuncionario.Clear();
                                    txtFuncionario.Clear();
                                    txtCodCliente.Clear();
                                    txtNomeCliente.Clear();
                                    mskTel.Clear();
                                    txtEndereco.Clear();
                                    txtComplemento.Clear();
                                    txtBairro.Clear();
                                    txtCidade.Clear();
                                    cboDescricao.Items.Clear();
                                    lboProdutos.Items.Clear();
                                    txtValor.Clear();
                                    txtObservacoes.Clear();
                                    txtTotalAPagar.Clear();
                                    txtCodFuncionario.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao incluir o pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }

                }
            }

        }

        private void cboDescricao_Click(object sender, EventArgs e)
        {
            cboDescricao.Items.Clear();
            List<Produto> Produtos = new List<Produto>();
            Produtos = ProdutoDAO.ObterProdutos();
            // ao clicar no combobox ele carrega uma lista de produtos do banco
            foreach (Produto x in Produtos)
            {
                cboDescricao.Items.Add(x.Descricao);
            }
            Produto produto = new Produto();        
           
        }

        float valor;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cboDescricao.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Produto produto = new Produto();
                lboProdutos.Items.Add(cboDescricao.SelectedItem);
                txtTotalAPagar.Text = 0.ToString();
                // verifica todos os produtos do listbox e soma o valor dos que foram selecionados e coloca no total
                foreach (string item in lboProdutos.Items)
                {
                    produto = ProdutoDAO.ObterProdutoPorNome(item);
                    valor = valor + produto.Valor;
                    txtTotalAPagar.Text = valor.ToString();
                }
                valor = 0;
            }
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            lboProdutos.Items.Remove(lboProdutos.SelectedItem);
            Produto produto = new Produto();
            txtTotalAPagar.Text = 0.ToString();
            // verifica todos os produtos do listbox e soma o valor dos que foram selecionados e coloca no total
            foreach (string item in lboProdutos.Items)
            {
                produto = ProdutoDAO.ObterProdutoPorNome(item);
                valor = valor + produto.Valor;
                txtTotalAPagar.Text = valor.ToString();
            }
            valor = 0;
        }

        private void mnConsultaFunc_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario form = new frmConsultaFuncionario();
            form.ShowDialog();
        }

        private void mnConsultaCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente form = new frmConsultaCliente();
            form.ShowDialog();
        }

        private void mnConsultaProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto form = new frmConsultaProduto();
            form.ShowDialog();
        }


        private void mnConsultaPedido_Click(object sender, EventArgs e)
        {
            frmConsultaPedido form = new frmConsultaPedido();
            form.ShowDialog();
        }

        private void btnProcurar1_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            if (string.IsNullOrWhiteSpace(txtCodFuncionario.Text))
            {
                MessageBox.Show("Insira um código", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                f = FuncionarioDAO.ObterFuncionarioPorId(int.Parse(txtCodFuncionario.Text));
                if (f == null)
                {
                    MessageBox.Show("Funcionário não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtFuncionario.Text = f.Nome;
                }
            }

        }

        private void btnProcurar2_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            if (string.IsNullOrWhiteSpace(txtCodCliente.Text))
            {
                MessageBox.Show("Insira um código", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                c = ClienteDAO.ObterClientePorId(int.Parse(txtCodCliente.Text));
                if (c == null)
                {
                    MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtNomeCliente.Text = c.Nome;
                    mskTel.Text = c.Telefone;
                    txtEndereco.Text = c.Endereco;
                    txtComplemento.Text = c.Complemento;
                    txtBairro.Text = c.Bairro;
                    txtCidade.Text = c.Cidade;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {

            // ao selecionar o produto, o valor unitário recebe o valor do produto
            if (cboDescricao.SelectedItem != null)
            {
                Produto produto = new Produto();
                produto = ProdutoDAO.ObterProdutoPorNome(cboDescricao.SelectedItem.ToString());
                txtValor.Text = produto.Valor.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtCodFuncionario.Clear();
            txtFuncionario.Clear();
            txtCodCliente.Clear();
            txtNomeCliente.Clear();
            mskTel.Clear();
            txtEndereco.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtValor.Clear();
            cboDescricao.Items.Clear();
            lboProdutos.Items.Clear();
            txtObservacoes.Clear();
            txtTotalAPagar.Clear();
            txtCodFuncionario.Focus();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // esse parte foi para desbugar o problema no banco
            // aqui esta sendo carregado todos os pedidos/clientes/produtos/funcionarios
            List<Pedido> p = new List<Pedido>();
            p = PedidoDAO.ObterPedidos();
            List<Funcionario> f = new List<Funcionario>();
            f = FuncionarioDAO.ObterFuncionarios();
            ICollection<Produto> prod = new List<Produto>();
            prod = ProdutoDAO.ObterProdutos();
            ICollection<Cliente> c = new List<Cliente>();
            c = ClienteDAO.ObterClientes();

        }

        private void mnEncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

