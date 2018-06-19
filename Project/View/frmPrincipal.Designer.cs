using System;

namespace Project
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnEncerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaProd = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPedido = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCodPedido = new System.Windows.Forms.Label();
            this.btnIncluirPedido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.grpFuncionario = new System.Windows.Forms.GroupBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.btnProcurar1 = new System.Windows.Forms.Button();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.btnProcurar2 = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lboProdutos = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cboDescricao = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.mnMenuPrincipal.SuspendLayout();
            this.grpPedido.SuspendLayout();
            this.grpFuncionario.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.grpProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMenuPrincipal
            // 
            this.mnMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastros,
            this.consultasToolStripMenuItem});
            this.mnMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnMenuPrincipal.Name = "mnMenuPrincipal";
            this.mnMenuPrincipal.Size = new System.Drawing.Size(845, 24);
            this.mnMenuPrincipal.TabIndex = 0;
            this.mnMenuPrincipal.Text = "menuStrip1";
            // 
            // mnCadastros
            // 
            this.mnCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadFuncionario,
            this.mnCadCliente,
            this.mnCadProduto,
            this.toolStripSeparator1,
            this.mnEncerrar});
            this.mnCadastros.Name = "mnCadastros";
            this.mnCadastros.Size = new System.Drawing.Size(71, 20);
            this.mnCadastros.Text = "Cadastros";
            // 
            // mnCadFuncionario
            // 
            this.mnCadFuncionario.Name = "mnCadFuncionario";
            this.mnCadFuncionario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnCadFuncionario.Size = new System.Drawing.Size(241, 22);
            this.mnCadFuncionario.Text = "Cadastro de &funcionário";
            this.mnCadFuncionario.Click += new System.EventHandler(this.mnCadFuncionario_Click);
            // 
            // mnCadCliente
            // 
            this.mnCadCliente.Name = "mnCadCliente";
            this.mnCadCliente.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnCadCliente.Size = new System.Drawing.Size(241, 22);
            this.mnCadCliente.Text = "Cadastro de &cliente";
            this.mnCadCliente.Click += new System.EventHandler(this.mnCadCliente_Click);
            // 
            // mnCadProduto
            // 
            this.mnCadProduto.Name = "mnCadProduto";
            this.mnCadProduto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnCadProduto.Size = new System.Drawing.Size(241, 22);
            this.mnCadProduto.Text = "Cadastro de &produto";
            this.mnCadProduto.Click += new System.EventHandler(this.mnCadProduto_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // mnEncerrar
            // 
            this.mnEncerrar.Name = "mnEncerrar";
            this.mnEncerrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5)));
            this.mnEncerrar.Size = new System.Drawing.Size(241, 22);
            this.mnEncerrar.Text = "Encerrar";
            this.mnEncerrar.Click += new System.EventHandler(this.mnEncerrar_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnConsultaPedido,
            this.mnConsultaFunc,
            this.mnConsultaCliente,
            this.mnConsultaProd});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // mnConsultaPedido
            // 
            this.mnConsultaPedido.Name = "mnConsultaPedido";
            this.mnConsultaPedido.Size = new System.Drawing.Size(137, 22);
            this.mnConsultaPedido.Text = "Pedido";
            this.mnConsultaPedido.Click += new System.EventHandler(this.mnConsultaPedido_Click);
            // 
            // mnConsultaFunc
            // 
            this.mnConsultaFunc.Name = "mnConsultaFunc";
            this.mnConsultaFunc.Size = new System.Drawing.Size(137, 22);
            this.mnConsultaFunc.Text = "Funcionário";
            this.mnConsultaFunc.Click += new System.EventHandler(this.mnConsultaFunc_Click);
            // 
            // mnConsultaCliente
            // 
            this.mnConsultaCliente.Name = "mnConsultaCliente";
            this.mnConsultaCliente.Size = new System.Drawing.Size(137, 22);
            this.mnConsultaCliente.Text = "Cliente";
            this.mnConsultaCliente.Click += new System.EventHandler(this.mnConsultaCliente_Click);
            // 
            // mnConsultaProd
            // 
            this.mnConsultaProd.Name = "mnConsultaProd";
            this.mnConsultaProd.Size = new System.Drawing.Size(137, 22);
            this.mnConsultaProd.Text = "Produto";
            this.mnConsultaProd.Click += new System.EventHandler(this.mnConsultaProd_Click);
            // 
            // grpPedido
            // 
            this.grpPedido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpPedido.Controls.Add(this.btnLimpar);
            this.grpPedido.Controls.Add(this.txtId);
            this.grpPedido.Controls.Add(this.lblCodPedido);
            this.grpPedido.Controls.Add(this.btnIncluirPedido);
            this.grpPedido.Controls.Add(this.btnCancelar);
            this.grpPedido.Controls.Add(this.lblObservacoes);
            this.grpPedido.Controls.Add(this.lblTotalAPagar);
            this.grpPedido.Controls.Add(this.grpFuncionario);
            this.grpPedido.Controls.Add(this.txtObservacoes);
            this.grpPedido.Controls.Add(this.txtTotalAPagar);
            this.grpPedido.Controls.Add(this.grpCliente);
            this.grpPedido.Controls.Add(this.grpProdutos);
            this.grpPedido.Location = new System.Drawing.Point(13, 28);
            this.grpPedido.Name = "grpPedido";
            this.grpPedido.Size = new System.Drawing.Size(791, 386);
            this.grpPedido.TabIndex = 1;
            this.grpPedido.TabStop = false;
            this.grpPedido.Text = "Pedido";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(467, 340);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 23);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(67, 17);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(46, 20);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            // 
            // lblCodPedido
            // 
            this.lblCodPedido.AutoSize = true;
            this.lblCodPedido.Location = new System.Drawing.Point(11, 20);
            this.lblCodPedido.Name = "lblCodPedido";
            this.lblCodPedido.Size = new System.Drawing.Size(54, 13);
            this.lblCodPedido.TabIndex = 23;
            this.lblCodPedido.Text = "Nº pedido";
            // 
            // btnIncluirPedido
            // 
            this.btnIncluirPedido.Location = new System.Drawing.Point(357, 340);
            this.btnIncluirPedido.Name = "btnIncluirPedido";
            this.btnIncluirPedido.Size = new System.Drawing.Size(96, 23);
            this.btnIncluirPedido.TabIndex = 21;
            this.btnIncluirPedido.Text = "Incluir pedido";
            this.btnIncluirPedido.UseVisualStyleBackColor = true;
            this.btnIncluirPedido.Click += new System.EventHandler(this.btnIncluirPedido_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(585, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(321, 257);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(70, 13);
            this.lblObservacoes.TabIndex = 25;
            this.lblObservacoes.Text = "Observações";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(321, 284);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAPagar.TabIndex = 25;
            this.lblTotalAPagar.Text = "Total à pagar";
            // 
            // grpFuncionario
            // 
            this.grpFuncionario.Controls.Add(this.lblFuncionario);
            this.grpFuncionario.Controls.Add(this.lblCodFuncionario);
            this.grpFuncionario.Controls.Add(this.txtFuncionario);
            this.grpFuncionario.Controls.Add(this.txtCodFuncionario);
            this.grpFuncionario.Controls.Add(this.btnProcurar1);
            this.grpFuncionario.Location = new System.Drawing.Point(6, 43);
            this.grpFuncionario.Name = "grpFuncionario";
            this.grpFuncionario.Size = new System.Drawing.Size(267, 87);
            this.grpFuncionario.TabIndex = 26;
            this.grpFuncionario.TabStop = false;
            this.grpFuncionario.Text = "Funcionário";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(9, 54);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 22;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.Location = new System.Drawing.Point(9, 22);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(84, 13);
            this.lblCodFuncionario.TabIndex = 22;
            this.lblCodFuncionario.Text = "Cód. funcionário";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Location = new System.Drawing.Point(75, 51);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.ReadOnly = true;
            this.txtFuncionario.Size = new System.Drawing.Size(94, 20);
            this.txtFuncionario.TabIndex = 4;
            this.txtFuncionario.TabStop = false;
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.Location = new System.Drawing.Point(94, 19);
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.Size = new System.Drawing.Size(75, 20);
            this.txtCodFuncionario.TabIndex = 2;
            // 
            // btnProcurar1
            // 
            this.btnProcurar1.Location = new System.Drawing.Point(177, 17);
            this.btnProcurar1.Name = "btnProcurar1";
            this.btnProcurar1.Size = new System.Drawing.Size(75, 22);
            this.btnProcurar1.TabIndex = 3;
            this.btnProcurar1.Text = "Procurar";
            this.btnProcurar1.UseVisualStyleBackColor = true;
            this.btnProcurar1.Click += new System.EventHandler(this.btnProcurar1_Click);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(397, 254);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(261, 20);
            this.txtObservacoes.TabIndex = 18;
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Enabled = false;
            this.txtTotalAPagar.Location = new System.Drawing.Point(397, 280);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.ReadOnly = true;
            this.txtTotalAPagar.Size = new System.Drawing.Size(75, 20);
            this.txtTotalAPagar.TabIndex = 19;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.mskTel);
            this.grpCliente.Controls.Add(this.lblTelefone);
            this.grpCliente.Controls.Add(this.lblCodCliente);
            this.grpCliente.Controls.Add(this.txtCodCliente);
            this.grpCliente.Controls.Add(this.btnProcurar2);
            this.grpCliente.Controls.Add(this.lblNomeCliente);
            this.grpCliente.Controls.Add(this.txtComplemento);
            this.grpCliente.Controls.Add(this.txtNomeCliente);
            this.grpCliente.Controls.Add(this.lblComplemento);
            this.grpCliente.Controls.Add(this.lblEndereco);
            this.grpCliente.Controls.Add(this.txtCidade);
            this.grpCliente.Controls.Add(this.txtEndereco);
            this.grpCliente.Controls.Add(this.lblCidade);
            this.grpCliente.Controls.Add(this.lblBairro);
            this.grpCliente.Controls.Add(this.txtBairro);
            this.grpCliente.Location = new System.Drawing.Point(6, 136);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(267, 242);
            this.grpCliente.TabIndex = 25;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // mskTel
            // 
            this.mskTel.Enabled = false;
            this.mskTel.Location = new System.Drawing.Point(61, 84);
            this.mskTel.Mask = "(99) 9999-9999";
            this.mskTel.Name = "mskTel";
            this.mskTel.ReadOnly = true;
            this.mskTel.Size = new System.Drawing.Size(168, 20);
            this.mskTel.TabIndex = 8;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(5, 87);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 22;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(7, 23);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(63, 13);
            this.lblCodCliente.TabIndex = 0;
            this.lblCodCliente.Text = "Cód. cliente";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(73, 20);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(75, 20);
            this.txtCodCliente.TabIndex = 5;
            // 
            // btnProcurar2
            // 
            this.btnProcurar2.Location = new System.Drawing.Point(154, 18);
            this.btnProcurar2.Name = "btnProcurar2";
            this.btnProcurar2.Size = new System.Drawing.Size(75, 22);
            this.btnProcurar2.TabIndex = 6;
            this.btnProcurar2.Text = "Procurar";
            this.btnProcurar2.UseVisualStyleBackColor = true;
            this.btnProcurar2.Click += new System.EventHandler(this.btnProcurar2_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(7, 57);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCliente.TabIndex = 12;
            this.lblNomeCliente.Text = "Nome";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(83, 139);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.ReadOnly = true;
            this.txtComplemento.Size = new System.Drawing.Size(144, 20);
            this.txtComplemento.TabIndex = 10;
            this.txtComplemento.TabStop = false;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(63, 54);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(166, 20);
            this.txtNomeCliente.TabIndex = 7;
            this.txtNomeCliente.TabStop = false;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(6, 142);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 20;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(5, 114);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 14;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(61, 196);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(166, 20);
            this.txtCidade.TabIndex = 12;
            this.txtCidade.TabStop = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(61, 111);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(166, 20);
            this.txtEndereco.TabIndex = 9;
            this.txtEndereco.TabStop = false;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 200);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 18;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 170);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 16;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(61, 166);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(166, 20);
            this.txtBairro.TabIndex = 11;
            this.txtBairro.TabStop = false;
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.btnRemover);
            this.grpProdutos.Controls.Add(this.lboProdutos);
            this.grpProdutos.Controls.Add(this.btnAdicionar);
            this.grpProdutos.Controls.Add(this.cboDescricao);
            this.grpProdutos.Controls.Add(this.txtValor);
            this.grpProdutos.Controls.Add(this.lblDescricao);
            this.grpProdutos.Controls.Add(this.lblValor);
            this.grpProdutos.Location = new System.Drawing.Point(317, 20);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Size = new System.Drawing.Size(423, 220);
            this.grpProdutos.TabIndex = 24;
            this.grpProdutos.TabStop = false;
            this.grpProdutos.Text = "Produtos";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(336, 40);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(28, 23);
            this.btnRemover.TabIndex = 16;
            this.btnRemover.Text = "-";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lboProdutos
            // 
            this.lboProdutos.FormattingEnabled = true;
            this.lboProdutos.Location = new System.Drawing.Point(12, 85);
            this.lboProdutos.Name = "lboProdutos";
            this.lboProdutos.Size = new System.Drawing.Size(355, 95);
            this.lboProdutos.TabIndex = 17;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(302, 40);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(28, 23);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cboDescricao
            // 
            this.cboDescricao.FormattingEnabled = true;
            this.cboDescricao.Location = new System.Drawing.Point(14, 41);
            this.cboDescricao.Name = "cboDescricao";
            this.cboDescricao.Size = new System.Drawing.Size(186, 21);
            this.cboDescricao.TabIndex = 13;
            this.cboDescricao.SelectedIndexChanged += new System.EventHandler(this.cboDescricao_SelectedIndexChanged);
            this.cboDescricao.Click += new System.EventHandler(this.cboDescricao_Click);
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(218, 41);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(60, 20);
            this.txtValor.TabIndex = 14;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 25);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(226, 25);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(49, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor un.";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 418);
            this.Controls.Add(this.grpPedido);
            this.Controls.Add(this.mnMenuPrincipal);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnMenuPrincipal.ResumeLayout(false);
            this.mnMenuPrincipal.PerformLayout();
            this.grpPedido.ResumeLayout(false);
            this.grpPedido.PerformLayout();
            this.grpFuncionario.ResumeLayout(false);
            this.grpFuncionario.PerformLayout();
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpProdutos.ResumeLayout(false);
            this.grpProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnCadFuncionario;
        private System.Windows.Forms.ToolStripMenuItem mnCadCliente;
        private System.Windows.Forms.ToolStripMenuItem mnCadProduto;
        private System.Windows.Forms.GroupBox grpPedido;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.Button btnProcurar2;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.ComboBox cboDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grpFuncionario;
        private System.Windows.Forms.Label lblCodFuncionario;
        private System.Windows.Forms.TextBox txtCodFuncionario;
        private System.Windows.Forms.Button btnProcurar1;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluirPedido;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnEncerrar;
        private System.Windows.Forms.ListBox lboProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaPedido;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaFunc;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaCliente;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaProd;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCodPedido;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
    }
}

