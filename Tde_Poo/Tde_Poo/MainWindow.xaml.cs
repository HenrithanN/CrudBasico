using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tde_Poo
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Conexao D = new Conexao();
            D.CEP = txtCEP.Text;
            D.IdCliente = Convert.ToInt32(txtIdCliente.Text);
            D.Complemento = txtComplemento.Text;
            D.Cidade = txtCidade.Text;
            D.Nome = txtNome.Text;
            D.NomeD = txtNomeD.Text;
            D.Logradouro = txtLogradouro.Text;
            D.Estado = txtEstado.Text;
            D.Cadastrar();
            System.Windows.MessageBox.Show("Cadastro Realizado Com Sucesso!");            
        }
        private void BtnAlterar_Click_1(object sender, RoutedEventArgs e)
        {
            Conexao D = new Conexao();
            D.CEP = txtCEP.Text;
            D.IdCliente = Convert.ToInt32(txtIdCliente.Text);
            D.Complemento = txtComplemento.Text;
            D.Cidade = txtCidade.Text;
            D.Nome = txtNome.Text;
            D.NomeD = txtNomeD.Text;
            D.Logradouro = txtLogradouro.Text;
            D.Estado = txtEstado.Text;
            D.Alterar();
            System.Windows.MessageBox.Show("Dados Alterados Com Sucesso!");
        }

        private void BtnDeletar_Click(object sender, RoutedEventArgs e)
        {
            Conexao D = new Conexao();
            D.IdCliente = Convert.ToInt32(txtIdCliente.Text);
            D.Deletar();

            System.Windows.MessageBox.Show("Dados Deletados Com Sucesso!");
        }

        private void BtnPesquisar_Click(object sender, RoutedEventArgs e)
        {

            MostrarDados pesquisa = new MostrarDados();


            pesquisa.Show();

        }
        
    }
}
