using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.LivroUsuarioDal;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        private DataSet ds;
        public Form1()
        {
            InitializeComponent();
            ds = new();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Clear();
            
            if (radioButton1.Checked)
            {
                ds = new UsuarioDal.UsuarioDal().ListarUsuarios();
                dataGridView1.DataSource = ds.Tables[0];
            } 
            else if (radioButton2.Checked) 
            {
                ds = new LivroDal.LivroDal().ListarLivros();
                dataGridView1.DataSource = ds.Tables[0];
            } 
            else if (radioButton3.Checked)
            {
                ds = new LivroUsuarioDal.LivroUsuarioDal().listarEmprestimos();
                dataGridView1.DataSource = ds.Tables[0];
            }
            dataGridView1.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var form = new AddBook();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new AddUser();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
