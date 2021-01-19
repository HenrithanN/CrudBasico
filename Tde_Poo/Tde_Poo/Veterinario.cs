using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tde_Poo
{
    class Veterinario
    {
        SqlConnection con = new SqlConnection("Data Source=sql4.porta80.com.br;" + "initial Catalog=lojasparati;" + "User id=lojasparati;" + "password=5117556");
        SqlCommand cmd = new SqlCommand();
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Sintomas { get; set; }

        public DataTable Pesquisar()
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Veterinario";
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
            cmd.CommandText = "INSERT Veterinario(Email, RG, Endereco, CPF, Nome, Sintomas)" + "VALUES(@EMAIL, @RG, @ENDERECO, @CPF, @NOME, @SINTOMAS)";

            cmd.Parameters.AddWithValue("@EMAIL", Email);
            cmd.Parameters.AddWithValue("@RG", RG);
            cmd.Parameters.AddWithValue("@ENDERECO", Endereco);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@NOME", Nome);
            cmd.Parameters.AddWithValue("@SINTOMAS", Sintomas);
            cmd.ExecuteNonQuery();

            con.Close();


            return true;
        }

        public bool Alterar()
        {
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Veterinario SET NOME = @NOME, ENDERECO = @ENDERECO,Sintomas = @SINTOMAS, Email = @Email,RG = @RG WHERE Veterinario.CPF = @CPF";


            cmd.Parameters.AddWithValue("@EMAIL", Email);
            cmd.Parameters.AddWithValue("@RG", RG);
            cmd.Parameters.AddWithValue("@ENDERECO", Endereco);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@NOME", Nome);
            cmd.Parameters.AddWithValue("@SINTOMAS", Sintomas);
            cmd.ExecuteNonQuery();

            con.Close();

            return true;
        }

    }
}
