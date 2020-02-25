using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;
using WindowsFormsApp3.Dao;
using System.Data;



namespace WindowsFormsApp3.Bll
{
   public  class PessoaBll
    {
        PessoaDAO pessoaDAO = new PessoaDAO();


        public void salvar(Pessoa pessoa)
        {
            try{
                pessoaDAO.salvar(pessoa);
            }
            catch(Exception error)
            {
                throw error;
            }
        }


        public void editar(Pessoa pessoa)
        {
            try
            {
                pessoaDAO.editar(pessoa);
            }
            catch(Exception error)
            {
                throw error;
            }
        }


        public void excluir(Pessoa pessoa)
        {
            try
            {
                pessoaDAO.excluir(pessoa);
            }
            catch (Exception error)
            {
                throw error;
            }
        }






        public DataTable Listar()
        {
            try
            { 
            DataTable dt = new DataTable();
            dt = pessoaDAO.listar();
            return dt;
            }
            catch (Exception error)
            {
               throw error;
            }
        }


    }
}
