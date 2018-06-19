using Project.DAO;
using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class frmConsultaPedido : Form
    {
        public frmConsultaPedido()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtIdFuncionario.Clear();
            txtNomeFuncionario.Clear();
            txtIdCliente.Clear();
            txtNomeCliente.Clear();
            lboProdutos.Items.Clear();
            txtObservacoes.Clear();
            txtTotalAPagar.Clear();
            txtStatus.Clear();
            txtData.Clear();
            txtDataEnc.Clear();
            btnEncerrarPed.Enabled = false;
            btnProcurar.Enabled = true;
            btnExcluir.Enabled = false;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Insira um número para o pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Pedido p = new Pedido();
                p = PedidoDAO.ObterPedidoPorId(int.Parse(txtId.Text));
                if (p == null)
                {
                    MessageBox.Show("Pedido não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (Produto x in p.Produtos)
                    {
                        lboProdutos.Items.Add(x.Descricao);
                    }

                    if (p.Data == p.DataEnc)
                    {
                        txtDataEnc.Text = ".";
                        btnEncerrarPed.Enabled = true;

                    }
                    else
                    {
                        txtDataEnc.Text = p.DataEnc.ToString();
                    }

                    txtId.Text = p.Id.ToString();
                    txtIdCliente.Text = p.Cliente.Id.ToString();
                    txtNomeCliente.Text = p.Cliente.Nome.ToString();
                    lboProdutos.Text = p.Produtos.ToString();
                    txtObservacoes.Text = p.Obs;
                    txtTotalAPagar.Text = p.TotalAPagar.ToString();
                    txtStatus.Text = p.Status;
                    txtData.Text = p.Data.ToString();
                    txtIdFuncionario.Text = p.Funcionario.Id.ToString();
                    txtNomeFuncionario.Text = p.Funcionario.Nome;
                    btnProcurar.Enabled = false;
                    btnExcluir.Enabled = true;                   
                }
            }
        }


        private void btnEncerrarPed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Insira um número para o pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show("Deseja encerrar esse pedido do sistema?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    Pedido pedido = new Pedido();
                    pedido = PedidoDAO.ObterPedidoPorId(int.Parse(txtId.Text));
                    pedido.Status = "Encerrado";
                    pedido.DataEnc = DateTime.Now;
                    if (PedidoDAO.Alterar(pedido))
                    {
                        MessageBox.Show("Pedido encerrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Pedido p = new Pedido();
                        p = PedidoDAO.ObterPedidoPorId(int.Parse(txtId.Text));
                        txtStatus.Text = p.Status;
                        txtDataEnc.Text = p.DataEnc.ToString();
                        btnEncerrarPed.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao encerrar pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtIdFuncionario.Text))
            {
                MessageBox.Show("Insira o código do pedido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pedido pedido = new Pedido();
                pedido = PedidoDAO.ObterPedidoPorId(int.Parse(txtId.Text));
                DialogResult result = MessageBox.Show("Deseja remover esse pedido do sistema? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (PedidoDAO.Excluir(pedido))
                    {
                        MessageBox.Show("Pedido excluído com sucesso", "Sucesso", MessageBoxButtons.OK);
                        txtId.Clear();
                        txtIdFuncionario.Clear();
                        txtNomeFuncionario.Clear();
                        txtIdCliente.Clear();
                        txtNomeCliente.Clear();
                        lboProdutos.Items.Clear();
                        txtObservacoes.Clear();
                        txtTotalAPagar.Clear();
                        txtStatus.Clear();
                        txtData.Clear();
                        txtDataEnc.Clear();
                        btnEncerrarPed.Enabled = false;
                        btnProcurar.Enabled = true;
                        btnExcluir.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }

}

