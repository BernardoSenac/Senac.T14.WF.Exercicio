using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }

        private void CriarBancoDeDados()
        {
            using (var BancoDeDados = new AppDbContext())
            {
                BancoDeDados.Database.Migrate();
            }
        }

private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            new FrmChamados().ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
