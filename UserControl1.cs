using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProiectPAW
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var colors = new[] { Color.White, Color.Black };
            var index = DateTime.Now.Second % colors.Length;
            label1.ForeColor = colors[index];
        }
    }
}
