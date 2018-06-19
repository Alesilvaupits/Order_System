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
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
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
            mskCpf.Clear();
            txtNomeFuncionario.Clear();
            txtNomeFuncionario.Focus();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!txtNomeFuncionario.Text.Equals("") && !mskCpf.Text.Equals(""))
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = txtNomeFuncionario.Text;
                funcionario.Cpf = mskCpf.Text;
                if (FuncionarioDAO.ObterFuncionarioPorCpf(funcionario.Cpf) == null)
                {
                    if (FuncionarioDAO.Incluir(funcionario))
                    {
                        funcionario = FuncionarioDAO.ObterFuncionarioPorCpf(funcionario.Cpf);
                        txtId.Text = funcionario.Id.ToString();
                        MessageBox.Show("Funcionário nº " + txtId.Text + " cadastrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mskCpf.Clear();
                        txtNomeFuncionario.Clear();
                        txtNomeFuncionario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao tentar incluir o funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cpf já cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


    }
}

