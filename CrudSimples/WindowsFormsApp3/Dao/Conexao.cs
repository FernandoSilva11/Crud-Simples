using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;




namespace WindowsFormsApp3
{
    class Conexao
    {
        string conecta="SERVER=localhost;DATABASE=Escola;UID=root; PWD=root";
        protected MySqlConnection conexao = null;
       

        public void AbriConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open(); 
            }
            catch(Exception erro)
            {
                throw erro;
            }

        }


        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch(Exception error)
            {
                throw error;
            }
        }



    }
}
