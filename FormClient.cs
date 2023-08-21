using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class FormClient : Form
    {
        public Client cFormClient;
        public FormClient(Client c)
        {
            InitializeComponent();
            if (c==null)
                cFormClient = new Client();
            else
            {
                cFormClient = c;
                textBox1.Text = cFormClient.nume;
                textBox2.Text = cFormClient.cnp;
                textBox3.Text = cFormClient.telefon;
                textBox4.Text = cFormClient.email;
            }
        }
        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cFormClient.nume = textBox1.Text;
            cFormClient.cnp = textBox2.Text;
            cFormClient.telefon = textBox3.Text;
            cFormClient.email = textBox4.Text;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length < 4)
            {
                errorProvider1.SetError(textBox1, "Numele este prea scurt!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBox1, "");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length != 13)
            {
                errorProvider2.SetError(textBox2, "CNP-ul trebuie sa contina 13 caractere!");
                e.Cancel = true;
            }
            else
                errorProvider2.SetError(textBox2, "");
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Length != 10)
            {
                errorProvider3.SetError(textBox3, "Numarul de telefon trebuie sa contina 10 caractere!");
                e.Cancel = true;
            }
            else
                errorProvider3.SetError(textBox3, "");
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text.Length < 7)
            {
                errorProvider4.SetError(textBox4, "Adresa de email trebuie sa contina mai mult de 7 caractere!");
                e.Cancel = true;
            }
            else
                errorProvider4.SetError(textBox4, "");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SelectNextControl(ActiveControl, true, true, true, true);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SelectNextControl(ActiveControl, true, true, true, true);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SelectNextControl(ActiveControl, true, true, true, true);
        }
    }
}
