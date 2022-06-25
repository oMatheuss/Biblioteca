using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var titulo = label1.Text;
            var autor = label2.Text;
            var editora = label3.Text;
            int ano = 0;
            int qtd = 0;

            try
            {
                ano = Int32.Parse(label4.Text);
            } catch (Exception)
            {
                MessageBox.Show("Ano incorreto!");
                return;
            }

            try
            {
                qtd = Int32.Parse(label5.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Quantidade incorreta!");
                return;
            }

            var livro = new Models.Livro()
            {
                Titulo = titulo,
                Autor = autor,
                Editora = editora,
                Ano = ano,
                Quantidade = qtd
            };

            if (new LivroDal.LivroDal().AdicionarLivro(livro) > 0)
            {
                MessageBox.Show("Livro adcionado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }
    }
}
