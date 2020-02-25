using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WindowsFormsApp3.Model;
using MySql.Data;
using System.Data;

using System.Data.SqlClient;

namespace WindowsFormsApp3.Dao
{
    class PessoaDAO : Conexao 
    {
        private string vsql = "";
        SqlConnection objCon = null;
        MySqlCommand comando = null;
        public void salvar(Pessoa pessoa)
        {
            try
            {
                AbriConexao();
                comando = new MySqlCommand("INSERT INTO pessoa (nome, sexo, telefone, celular, endereco, bairro, cidade, estado ) VALUES(@nome, @sexo, @telefone, @celular, @endereco, @bairro, @cidade, @estado)", conexao);

                comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@sexo", pessoa.Sexo);
                comando.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                comando.Parameters.AddWithValue("@celular", pessoa.Celular);
                comando.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                comando.Parameters.AddWithValue("@bairro", pessoa.Bairro);
                comando.Parameters.AddWithValue("@cidade", pessoa.Cidade);
                comando.Parameters.AddWithValue("@estado", pessoa.Estado);

                comando.ExecuteNonQuery();
            }
            catch(Exception error)
            {
                throw error;
            }
            finally
            {
                FecharConexao();
            }
        }


        public void editar(Pessoa pessoa)
        {
            try
            {
                AbriConexao();
                comando = new MySqlCommand("UPDATE pessoa set nome=@nome, sexo=@sexo, telefone=@telefone, celular=@celular, endereco=@endereco, bairro=@bairro, cidade=@cidade, estado=@estado where id_pessoa=@idPessoa",conexao);

                comando.Parameters.AddWithValue("@idPessoa", pessoa.Id_Pessoa);
                comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@sexo", pessoa.Sexo);
                comando.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                comando.Parameters.AddWithValue("@celular", pessoa.Celular);
                comando.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                comando.Parameters.AddWithValue("@bairro", pessoa.Bairro);
                comando.Parameters.AddWithValue("@cidade", pessoa.Cidade);
                comando.Parameters.AddWithValue("@estado", pessoa.Estado);

                comando.ExecuteNonQuery();
                
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void excluir(Pessoa pessoa)
        {
            try
            {
                AbriConexao();
                comando = new MySqlCommand("delete from pessoa where id_pessoa=@idPessoa", conexao);

                comando.Parameters.AddWithValue("@idPessoa", pessoa.Id_Pessoa);

                comando.ExecuteNonQuery();

            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                FecharConexao();
            }

        }





        public DataTable listar()
        {
            try
            {
                AbriConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("select * from pessoa order by id_pessoa", conexao);
                da.SelectCommand=comando;

                da.Fill(dt);

                return dt;

            }
            catch(Exception error)
            {
                throw error;
            }
            finally
            {
                FecharConexao();
            }
        }



    }
}
