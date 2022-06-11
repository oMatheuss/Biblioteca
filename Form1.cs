using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Daos;
using Biblioteca.Daos.LivroUsuarioDao;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        private DataSet ds;
        public Form1()
        {
            InitializeComponent();
            ds = new();
            dataGridView1.DataSource = ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Clear();
            
            if (radioButton1.Checked)
            {
                ds = new UsuarioDao.UsuarioDao().ListarUsuarios();
                
            } 
            else if (radioButton2.Checked) 
            {
                ds = new LivroDao.LivroDao().ListarLivros();
            } 
            else if (radioButton3.Checked)
            {
                ds = new LivroUsuarioDao().listarEmprestimos();
            }
            dataGridView1.Refresh();
        }
    }
}
