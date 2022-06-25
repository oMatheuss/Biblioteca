using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.UsuarioDal;

namespace Biblioteca
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = label2.Text;
            var telefone = label1.Text;

            if (telefone.Length != 11)
            {
                MessageBox.Show("Telefone incorreto! Deve conter 11 numeros. Atual: " + telefone.Length);
                return;
            }

            var user = new Models.Usuario()
            {
                Nome = nome,
                Telefone = telefone
            };

            if (new UsuarioDal.UsuarioDal().AdicionarUsuario(user) > 0)
            {
                MessageBox.Show("Usuario adcionado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }
    }
}
