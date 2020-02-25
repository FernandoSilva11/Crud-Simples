using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Bll;
using WindowsFormsApp3.Model;




namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Listar();
        }


        private void LimparCampos()
        {
            txt_Cod.Clear();
            txt_Nome.Clear();
            cb_Sexo.SelectedIndex = -1;
            txt_endereco.Clear();
            mtb_tel.Clear();
            mtb_cel.Clear();
            txt_Bairro.Clear();
            txt_cidade.Clear();
            cb_uf.SelectedIndex = -1;
            txt_Nome.BackColor = Color.White;
            txt_endereco.BackColor = Color.White;
            cb_Sexo.BackColor = Color.White;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            PessoaBll pessoaBll = new PessoaBll();

            dg_dados.DataSource = pessoaBll.Listar();

            dg_dados.Columns[0].HeaderText = "Cod";
            dg_dados.Columns[1].HeaderText = "Nome";
            dg_dados.Columns[2].HeaderText = "Sexo";
            dg_dados.Columns[3].HeaderText = "Telefone";
            dg_dados.Columns[4].HeaderText = "Celular";
            dg_dados.Columns[5].HeaderText = "Endereço";
            dg_dados.Columns[6].HeaderText = "Bairro";
            dg_dados.Columns[7].HeaderText = "Cidade";
            dg_dados.Columns[8].HeaderText = "Estado";

            dg_dados.Columns[0].Width = 40;
            dg_dados.Columns[1].Width = 120;
            dg_dados.Columns[2].Width = 40;
            dg_dados.Columns[8].Width = 50;

        }





        private void Salvar(Pessoa pessoa)
        {
            if (txt_Nome.Text.Trim() == string.Empty || cb_Sexo.Text.Trim() == string.Empty || txt_endereco.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Existem campos para serem preenchidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nome.BackColor = Color.Beige;
                txt_endereco.BackColor = Color.Beige;
                cb_Sexo.BackColor = Color.Beige;
            }
            else 
            { 
            PessoaBll pessoaBll = new PessoaBll();
            pessoa.Nome = txt_Nome.Text;
            pessoa.Sexo = cb_Sexo.Text;
            pessoa.Telefone = mtb_tel.Text;
            pessoa.Celular = mtb_cel.Text;
            pessoa.Endereco = txt_endereco.Text;
            pessoa.Bairro = txt_Bairro.Text;
            pessoa.Cidade = txt_Bairro.Text;
            pessoa.Estado = cb_uf.Text;

            pessoaBll.salvar(pessoa);

            MessageBox.Show("Pessoa salvar com sucesso");
            LimparCampos();
            Listar();
            }
        }


        private void Editar(Pessoa pessoa )
        {
            if (txt_Nome.Text.Trim() == string.Empty || cb_Sexo.Text.Trim() == string.Empty || txt_endereco.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Existem campos para serem preenchidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nome.BackColor = Color.Beige;
                txt_endereco.BackColor = Color.Beige;
                cb_Sexo.BackColor = Color.Beige;
            }
            else
            {



                PessoaBll pessoaBll = new PessoaBll();

                pessoa.Id_Pessoa = Convert.ToInt32(txt_Cod.Text);
                pessoa.Nome = txt_Nome.Text;
                pessoa.Sexo = cb_Sexo.Text;
                pessoa.Telefone = mtb_tel.Text;
                pessoa.Celular = mtb_cel.Text;
                pessoa.Endereco = txt_endereco.Text;
                pessoa.Bairro = txt_Bairro.Text;
                pessoa.Cidade = txt_cidade.Text;
                pessoa.Estado = cb_uf.Text;

                pessoaBll.editar(pessoa);

                MessageBox.Show("Pessoa editada com sucesso");
                LimparCampos();
                Listar();
            }

        }

        private void Excluir(Pessoa pessoa)
        {
            if (txt_Cod.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione uma pessoa para ser excluida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (MessageBox.Show("Você quer excluir essa pessoa?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                LimparCampos();
            }
            else
            {
               
            PessoaBll pessoaBll = new PessoaBll();

            pessoa.Id_Pessoa = Convert.ToInt32(txt_Cod.Text);

            pessoaBll.excluir(pessoa);
            MessageBox.Show("Pessoa excluida com sucesso");
            LimparCampos();
            Listar();
        }
        }


        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            Salvar(pessoa);
        }

        private void Dg_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Cod.Text = dg_dados.CurrentRow.Cells[0].Value.ToString();
            txt_Nome.Text = dg_dados.CurrentRow.Cells[1].Value.ToString();
            cb_Sexo.Text = dg_dados.CurrentRow.Cells[2].Value.ToString();
            mtb_tel.Text = dg_dados.CurrentRow.Cells[3].Value.ToString();
            mtb_cel.Text = dg_dados.CurrentRow.Cells[4].Value.ToString();
            txt_endereco.Text= dg_dados.CurrentRow.Cells[5].Value.ToString();
            txt_Bairro.Text= dg_dados.CurrentRow.Cells[6].Value.ToString();
            txt_cidade.Text= dg_dados.CurrentRow.Cells[7].Value.ToString();
            cb_uf.Text= dg_dados.CurrentRow.Cells[8].Value.ToString();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            Editar(pessoa);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            Excluir(pessoa);
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
