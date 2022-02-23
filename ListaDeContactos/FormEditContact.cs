using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeContactos
{
    public partial class FormEditContact : Form
    {
        public FormEditContact(string setName, string setAddress, string setNumber)
        {
            InitializeComponent();
            textBoxNome.Text = setName;
            textBoxMorada.Text = setAddress;
            textBoxNumero.Text = setNumber;
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Form1.setName = textBoxNome.Text;
            Form1.setAddress = textBoxMorada.Text;
            Form1.setNumber = textBoxNumero.Text;
            this.Close();
        }
    }
}
