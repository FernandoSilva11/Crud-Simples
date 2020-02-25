namespace WindowsFormsApp3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Cod = new System.Windows.Forms.TextBox();
            this.cb_Sexo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.cb_uf = new System.Windows.Forms.ComboBox();
            this.mtb_tel = new System.Windows.Forms.MaskedTextBox();
            this.mtb_cel = new System.Windows.Forms.MaskedTextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(63, 35);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(276, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Cod
            // 
            this.txt_Cod.Enabled = false;
            this.txt_Cod.Location = new System.Drawing.Point(63, 9);
            this.txt_Cod.Name = "txt_Cod";
            this.txt_Cod.Size = new System.Drawing.Size(100, 20);
            this.txt_Cod.TabIndex = 0;
            // 
            // cb_Sexo
            // 
            this.cb_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sexo.FormattingEnabled = true;
            this.cb_Sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cb_Sexo.Location = new System.Drawing.Point(402, 35);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_Sexo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cód";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sexo";
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar.BackgroundImage")));
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salvar.Location = new System.Drawing.Point(10, 175);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(97, 39);
            this.btn_salvar.TabIndex = 9;
            this.toolTip.SetToolTip(this.btn_salvar, "Salvar");
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editar.Location = new System.Drawing.Point(123, 175);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(105, 39);
            this.btn_editar.TabIndex = 10;
            this.toolTip.SetToolTip(this.btn_editar, "Editar");
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excluir.BackgroundImage")));
            this.btn_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_excluir.Location = new System.Drawing.Point(244, 175);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(105, 39);
            this.btn_excluir.TabIndex = 11;
            this.toolTip.SetToolTip(this.btn_excluir, "Excluir");
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // dg_dados
            // 
            this.dg_dados.AllowUserToAddRows = false;
            this.dg_dados.AllowUserToDeleteRows = false;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(12, 220);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.ReadOnly = true;
            this.dg_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dados.Size = new System.Drawing.Size(621, 235);
            this.dg_dados.TabIndex = 18;
            this.dg_dados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_dados_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "UF";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(63, 98);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(276, 20);
            this.txt_Bairro.TabIndex = 4;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(402, 68);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(121, 20);
            this.txt_cidade.TabIndex = 5;
            // 
            // cb_uf
            // 
            this.cb_uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_uf.FormattingEnabled = true;
            this.cb_uf.Items.AddRange(new object[] {
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cb_uf.Location = new System.Drawing.Point(402, 101);
            this.cb_uf.Name = "cb_uf";
            this.cb_uf.Size = new System.Drawing.Size(121, 21);
            this.cb_uf.TabIndex = 6;
            // 
            // mtb_tel
            // 
            this.mtb_tel.Location = new System.Drawing.Point(63, 138);
            this.mtb_tel.Mask = "(00)0000-0000";
            this.mtb_tel.Name = "mtb_tel";
            this.mtb_tel.Size = new System.Drawing.Size(78, 20);
            this.mtb_tel.TabIndex = 7;
            // 
            // mtb_cel
            // 
            this.mtb_cel.Location = new System.Drawing.Point(215, 138);
            this.mtb_cel.Mask = "(00)00000-0000";
            this.mtb_cel.Name = "mtb_cel";
            this.mtb_cel.Size = new System.Drawing.Size(86, 20);
            this.mtb_cel.TabIndex = 8;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpar.BackgroundImage")));
            this.btn_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_limpar.Location = new System.Drawing.Point(368, 175);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(105, 39);
            this.btn_limpar.TabIndex = 12;
            this.toolTip.SetToolTip(this.btn_limpar, "Cancelar");
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(63, 65);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(276, 20);
            this.txt_endereco.TabIndex = 3;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(8, 68);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(53, 13);
            this.Label9.TabIndex = 33;
            this.Label9.Text = "Endereco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 467);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.mtb_cel);
            this.Controls.Add(this.mtb_tel);
            this.Controls.Add(this.cb_uf);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_dados);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Sexo);
            this.Controls.Add(this.txt_Cod);
            this.Controls.Add(this.txt_Nome);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crud";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Cod;
        private System.Windows.Forms.ComboBox cb_Sexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.ComboBox cb_uf;
        private System.Windows.Forms.MaskedTextBox mtb_tel;
        private System.Windows.Forms.MaskedTextBox mtb_cel;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

