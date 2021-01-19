using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tde_Poo
{
    public partial class MostrarDados : Form
    {
        public MostrarDados()
        {
            InitializeComponent();
        }

        private void MostrarDados_Load(object sender, EventArgs e)
        {
            Conexao D = new Conexao();
            GridPesquisar.DataSource = D.Pesquisar();
            
        }

    }
}
