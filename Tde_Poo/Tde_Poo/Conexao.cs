using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tde_Poo
{
    class Conexao : Cliente
    {
        SqlConnection con = new SqlConnection("Data Source=sql4.porta80.com.br;" + "initial Catalog=lojasparati;" + "User id=lojasparati;" + "password=5117556");
        SqlCommand cmd = new SqlCommand();
       
        public DataTable Pesquisar()
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ClientePOo";
            DataTable dt = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(dt);

            con.Close();

            return dt;
        }
        public bool Cadastrar()
        {
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT ClientePOo(Cidade, NomeD, Estado, CEP, Complemento, IdCliente, Nome, Logradouro)" + "VALUES(@CIDADE, @NOMED, @ESTADO, @CEP, @COMPLEMENTO, @IDCLIENTE, @NOME, @LOGRADOURO)";

            cmd.Parameters.AddWithValue("@CIDADE", Cidade);
            cmd.Parameters.AddWithValue("@ESTADO", Estado);
            cmd.Parameters.AddWithValue("@CEP", CEP);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", Complemento);
            cmd.Parameters.AddWithValue("@IDCLIENTE", IdCliente);
            cmd.Parameters.AddWithValue("@NOME", Nome);
            cmd.Parameters.AddWithValue("@NOMED", NomeD);
            cmd.Parameters.AddWithValue("@LOGRADOURO", Logradouro);
            cmd.ExecuteNonQuery();

            con.Close();


            return true;
        }

        public bool Alterar()
        {
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ClientePOo SET CIDADE = @CIDADE, NOME = @NOME,NOMED = @NOMED, COMPLEMENTO = @COMPLEMENTO,LOGRADOURO = @LOGRADOURO, IDCLIENTE = @IDCLIENTE,CEP = @CEP WHERE ClientePOo.idCliente = @IDCLIENTE";

            cmd.Parameters.AddWithValue("@CIDADE", Cidade);
            cmd.Parameters.AddWithValue("@ESTADO", Estado);
            cmd.Parameters.AddWithValue("@CEP", CEP);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", Complemento);
            cmd.Parameters.AddWithValue("@IDCLIENTE", IdCliente);
            cmd.Parameters.AddWithValue("@NOME", Nome);
            cmd.Parameters.AddWithValue("@NOMED", NomeD);
            cmd.Parameters.AddWithValue("@LOGRADOURO", Logradouro);
            cmd.ExecuteNonQuery();

            con.Close();

            return true;
        }
        public bool Deletar()
        {
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from ClientePOo where ClientePOo.IdCliente = @IDCLIENTE";
            cmd.Parameters.AddWithValue("@IDCLIENTE", IdCliente);
            cmd.ExecuteNonQuery();

            con.Close();

            return true;

        }

    }
}
