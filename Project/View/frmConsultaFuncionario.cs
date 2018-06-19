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
    public partial class frmConsultaFuncionario : Form
    {
        public frmConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            txtNomeFuncionario.Enabled = false;
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Insira o código do funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Funcionario f = new Funcionario();
                f = FuncionarioDAO.ObterFuncionarioPorId(int.Parse(txtId.Text));
                if (f == null)
                {
                    MessageBox.Show("Funcionário não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mskCpf.Text = f.Cpf;
                    txtNomeFuncionario.Text = f.Nome;
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtNomeFuncionario.Text))
            {
                MessageBox.Show("Insira o código do funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btnSalvar.Enabled = true;
                txtNomeFuncionario.Enabled = true;
                txtNomeFuncionario.ReadOnly = false;
                btnEditar.Enabled = false;
            }        
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(mskCpf.Text))
            {
                MessageBox.Show("Insira o código do funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!txtNomeFuncionario.Text.Equals("") && !mskCpf.Text.Equals(""))
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario = FuncionarioDAO.ObterFuncionarioPorId(int.Parse(txtId.Text));
                    funcionario.Nome = txtNomeFuncionario.Text;
                    funcionario.Cpf = mskCpf.Text;
                    DialogResult result = MessageBox.Show("Deseja salvar as alterações? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (FuncionarioDAO.Alterar(funcionario))
                        {
                            MessageBox.Show("Funcionário alterado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNomeFuncionario.Enabled = false;
                            btnSalvar.Enabled = false;
                            btnEditar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Erro durante a operação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos são de preenchimento obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            mskCpf.Clear();
            txtNomeFuncionario.Clear();
            txtId.Focus();
        }
    }
}

