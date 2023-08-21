using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProiectPAW //TEMA PROIECTULUI: GESTIUNE VANZARI
{
    public partial class Form1 : Form
    {
        int i = 0;

        Client c1 = new Client("Marius Bogdan", "7902627238253", "0787356324", "mbogdan@yahoo.com");
        Client c2 = new Client("Iordache Maria", "6256527358005", "0763541885", "imaria@gmail.com");
        Client c3 = new Client("Cerchez Ovidiu", "4966444451376", "0734641764", "covidiu@aol.com");
        Client c4 = new Client("Alexandru Dinu", "7583958674859", "0757485847", "adinu@aol.com");
        Client c5 = new Client("Valentin Florentina", "8375849687901", "0799879605", "vflorentina@yahoo.com");

        Produs p1 = new Produs("Canapea extensibila", 1500.00f);
        Produs p2 = new Produs("Canapea neextensibila", 950.60f);
        Produs p3 = new Produs("Fotoliu", 515.90f);
        Produs p4 = new Produs("Scaun de bucatarie", 139.88f);
        Produs p5 = new Produs("Scaun de birou", 249.00f);
        Produs p6 = new Produs("Scaun de exterior", 175.00f);
        Produs p7 = new Produs("Pat single", 799.99f);
        Produs p8 = new Produs("Pat double", 1499.99f);
        Produs p9 = new Produs("Noptiera", 225.00f);
        Produs p10 = new Produs("Masa de bucatarie", 359.80f);
        Produs p11 = new Produs("Masuta de cafea", 110.20f);
        Produs p12 = new Produs("Dulap", 794.37f);
        Produs p13 = new Produs("Covor 60x90 cm", 59.90f);
        Produs p14 = new Produs("Covor 80x150 cm", 159.90f);
        Produs p15 = new Produs("Covor 170x240 cm", 289.90f);
        Produs p16 = new Produs("Birou", 669.00f);
        public Form1()
        {
            InitializeComponent();

            ListViewItem lv1 = new ListViewItem(c1.nume);
            lv1.SubItems.Add(c1.telefon);
            lv1.SubItems.Add(c1.id.ToString());
            lv1.Tag = c1;
            ListViewItem lv2 = new ListViewItem(c2.nume);
            lv2.SubItems.Add(c2.telefon);
            lv2.SubItems.Add(c2.id.ToString());
            lv2.Tag = c2;
            ListViewItem lv3 = new ListViewItem(c3.nume);
            lv3.SubItems.Add(c3.telefon);
            lv3.SubItems.Add(c3.id.ToString());
            lv3.Tag = c3;
            ListViewItem lv4 = new ListViewItem(c4.nume);
            lv4.SubItems.Add(c4.telefon);
            lv4.SubItems.Add(c4.id.ToString());
            lv4.Tag = c4;
            ListViewItem lv5 = new ListViewItem(c5.nume);
            lv5.SubItems.Add(c5.telefon);
            lv5.SubItems.Add(c5.id.ToString());
            lv5.Tag = c5;
            listView1.Items.Add(lv1);
            listView1.Items.Add(lv2);
            listView1.Items.Add(lv3);
            listView1.Items.Add(lv4);
            listView1.Items.Add(lv5);            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //GENERARE BON
            if (listView1.SelectedItems.Count > 0)
            {
                Client client = listView1.SelectedItems[0].Tag as Client;
                List<Produs> produse = new List<Produs>();
                List<int> cantitati = new List<int>();
                if (checkBox1.Checked)
                {
                    produse.Add(p1);
                    cantitati.Add(int.Parse(comboBox1.Text));
                }
                if (checkBox2.Checked)
                {
                    produse.Add(p2);
                    cantitati.Add(int.Parse(comboBox2.Text));
                }
                if (checkBox3.Checked)
                {
                    produse.Add(p3);
                    cantitati.Add(int.Parse(comboBox3.Text));
                }
                if (checkBox4.Checked)
                {
                    produse.Add(p4);
                    cantitati.Add(int.Parse(comboBox4.Text));
                }
                if (checkBox5.Checked)
                {
                    produse.Add(p5);
                    cantitati.Add(int.Parse(comboBox5.Text));
                }
                if (checkBox6.Checked)
                {
                    produse.Add(p6);
                    cantitati.Add(int.Parse(comboBox6.Text));
                }
                if (checkBox7.Checked)
                {
                    produse.Add(p7);
                    cantitati.Add(int.Parse(comboBox7.Text));
                }
                if (checkBox8.Checked)
                {
                    produse.Add(p8);
                    cantitati.Add(int.Parse(comboBox8.Text));
                }
                if (checkBox9.Checked)
                {
                    produse.Add(p9);
                    cantitati.Add(int.Parse(comboBox9.Text));
                }
                if (checkBox10.Checked)
                {
                    produse.Add(p10);
                    cantitati.Add(int.Parse(comboBox10.Text));
                }
                if (checkBox11.Checked)
                {
                    produse.Add(p11);
                    cantitati.Add(int.Parse(comboBox11.Text));
                }
                if (checkBox12.Checked)
                {
                    produse.Add(p12);
                    cantitati.Add(int.Parse(comboBox12.Text));
                }
                if (checkBox13.Checked)
                {
                    produse.Add(p13);
                    cantitati.Add(int.Parse(comboBox13.Text));
                }
                if (checkBox14.Checked)
                {
                    produse.Add(p14);
                    cantitati.Add(int.Parse(comboBox14.Text));
                }
                if (checkBox15.Checked)
                {
                    produse.Add(p15);
                    cantitati.Add(int.Parse(comboBox15.Text));
                }
                if (checkBox16.Checked)
                {
                    produse.Add(p16);
                    cantitati.Add(int.Parse(comboBox16.Text));
                }
                Tranzactie tranzactie = new Tranzactie(client, produse, cantitati);
                textBox1.Text = tranzactie.ToString();
                textBox1.Tag = tranzactie;
            }
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient fc = new FormClient(null);
            if (fc.ShowDialog() == DialogResult.OK)
            {
                ListViewItem lv = new ListViewItem(fc.cFormClient.nume);
                lv.SubItems.Add(fc.cFormClient.telefon);
                lv.SubItems.Add(fc.cFormClient.id.ToString());
                lv.Tag = fc.cFormClient;
                listView1.Items.Add(lv);
            }
        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Client c = listView1.SelectedItems[0].Tag as Client;
                FormClient fc = new FormClient(c);
                if (fc.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lv = listView1.SelectedItems[0];
                    lv.Text = c.nume;
                    lv.SubItems[1].Text = c.telefon;
                    lv.SubItems[2].Text = c.id.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Bon fiscal", 300, 950);
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FontFamily fontfamily = new FontFamily("Courier New");
            Font font = new Font(fontfamily, 33, FontStyle.Regular, GraphicsUnit.Pixel);
            e.Graphics.DrawString(textBox1.Text, font, Brushes.Black, 10, 25);
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView1.DoDragDrop(listView1.SelectedItems[0].Tag as Client, DragDropEffects.Copy);
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Client)))
                e.Effect = DragDropEffects.Copy;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Client)))
            {
                if (e.Effect == DragDropEffects.Copy)
                {
                    Client client = e.Data.GetData(typeof(Client)) as Client;
                    List<Produs> produse = new List<Produs>();
                    List<int> cantitati = new List<int>();
                    if (checkBox1.Checked)
                    {
                        produse.Add(p1);
                        cantitati.Add(int.Parse(comboBox1.Text));
                    }
                    if (checkBox2.Checked)
                    {
                        produse.Add(p2);
                        cantitati.Add(int.Parse(comboBox2.Text));
                    }
                    if (checkBox3.Checked)
                    {
                        produse.Add(p3);
                        cantitati.Add(int.Parse(comboBox3.Text));
                    }
                    if (checkBox4.Checked)
                    {
                        produse.Add(p4);
                        cantitati.Add(int.Parse(comboBox4.Text));
                    }
                    if (checkBox5.Checked)
                    {
                        produse.Add(p5);
                        cantitati.Add(int.Parse(comboBox5.Text));
                    }
                    if (checkBox6.Checked)
                    {
                        produse.Add(p6);
                        cantitati.Add(int.Parse(comboBox6.Text));
                    }
                    if (checkBox7.Checked)
                    {
                        produse.Add(p7);
                        cantitati.Add(int.Parse(comboBox7.Text));
                    }
                    if (checkBox8.Checked)
                    {
                        produse.Add(p8);
                        cantitati.Add(int.Parse(comboBox8.Text));
                    }
                    if (checkBox9.Checked)
                    {
                        produse.Add(p9);
                        cantitati.Add(int.Parse(comboBox9.Text));
                    }
                    if (checkBox10.Checked)
                    {
                        produse.Add(p10);
                        cantitati.Add(int.Parse(comboBox10.Text));
                    }
                    if (checkBox11.Checked)
                    {
                        produse.Add(p11);
                        cantitati.Add(int.Parse(comboBox11.Text));
                    }
                    if (checkBox12.Checked)
                    {
                        produse.Add(p12);
                        cantitati.Add(int.Parse(comboBox12.Text));
                    }
                    if (checkBox13.Checked)
                    {
                        produse.Add(p13);
                        cantitati.Add(int.Parse(comboBox13.Text));
                    }
                    if (checkBox14.Checked)
                    {
                        produse.Add(p14);
                        cantitati.Add(int.Parse(comboBox14.Text));
                    }
                    if (checkBox15.Checked)
                    {
                        produse.Add(p15);
                        cantitati.Add(int.Parse(comboBox15.Text));
                    }
                    if (checkBox16.Checked)
                    {
                        produse.Add(p16);
                        cantitati.Add(int.Parse(comboBox16.Text));
                    }
                    Tranzactie tranzactie = new Tranzactie(client, produse, cantitati);
                    textBox1.Text = tranzactie.ToString();
                    textBox1.Tag = tranzactie;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Transaction file *.xml|*.xml";
            fd.CheckPathExists = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Tranzactie tranzactie = textBox1.Tag as Tranzactie;
                XmlSerializer serializator = new XmlSerializer(typeof(Tranzactie));
                StreamWriter writer = new StreamWriter(fd.FileName);
                serializator.Serialize(writer, tranzactie);
                writer.Close();
            }
            textBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Transaction file *.xml|*.xml";
            fd.CheckFileExists = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Tranzactie tranzactie = new Tranzactie();
                try
                {
                    XmlSerializer serializator = new XmlSerializer(typeof(Tranzactie));
                    StreamReader reader = new StreamReader(fd.FileName);
                    tranzactie = (Tranzactie)serializator.Deserialize(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox1.Text = tranzactie.ToString();
                textBox1.Tag = tranzactie;
            }
        }

        private void graficPreturiProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrafic formGrafic = new FormGrafic();
            formGrafic.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var msgbox = MessageBox.Show("Tranzactia a fost inregistrata!", "Succes", MessageBoxButtons.OK);
            textBox1.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;

            comboBox1.Items.Clear();
            comboBox1.ResetText();
            comboBox2.Items.Clear();
            comboBox2.ResetText();
            comboBox3.Items.Clear();
            comboBox3.ResetText();
            comboBox4.Items.Clear();
            comboBox4.ResetText();
            comboBox5.Items.Clear();
            comboBox5.ResetText();
            comboBox6.Items.Clear();
            comboBox6.ResetText();
            comboBox7.Items.Clear();
            comboBox7.ResetText();
            comboBox8.Items.Clear();
            comboBox8.ResetText();
            comboBox9.Items.Clear();
            comboBox9.ResetText();
            comboBox10.Items.Clear();
            comboBox10.ResetText();
            comboBox11.Items.Clear();
            comboBox11.ResetText();
            comboBox12.Items.Clear();
            comboBox12.ResetText();
            comboBox13.Items.Clear();
            comboBox13.ResetText();
            comboBox14.Items.Clear();
            comboBox14.ResetText();
            comboBox15.Items.Clear();
            comboBox15.ResetText();
            comboBox16.Items.Clear();
            comboBox16.ResetText();
        }
    }
}
