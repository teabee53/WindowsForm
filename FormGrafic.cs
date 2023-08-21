using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectPAW
{
    public partial class FormGrafic : Form
    {
        Produs p1 = new Produs("Canapea extens.", 1500.00f);
        Produs p2 = new Produs("Canapea neextens.", 950.60f);
        Produs p3 = new Produs("Fotoliu", 515.90f);
        Produs p4 = new Produs("Scaun bucatarie", 139.88f);
        Produs p5 = new Produs("Scaun birou", 249.00f);
        Produs p6 = new Produs("Scaun exterior", 175.00f);
        Produs p7 = new Produs("Pat single", 799.99f);
        Produs p8 = new Produs("Pat double", 1499.99f);
        Produs p9 = new Produs("Noptiera", 225.00f);
        Produs p10 = new Produs("Masa bucatarie", 359.80f);
        Produs p11 = new Produs("Masuta cafea", 110.20f);
        Produs p12 = new Produs("Dulap", 794.37f);
        Produs p13 = new Produs("Covor 60x90", 59.90f);
        Produs p14 = new Produs("Covor 80x150", 159.90f);
        Produs p15 = new Produs("Covor 170x240", 289.90f);
        Produs p16 = new Produs("Birou", 669.00f);

        float[] preturi;
        String[] denumiri;
        int nr;
        
        public FormGrafic()
        {
            InitializeComponent();
            Produs[] produse = new Produs[] { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16 };
            preturi = new float[16];
            denumiri = new String[16];
            for (int i =0;i<16;i++)
            {
                preturi[i] = produse[i].pret;
                denumiri[i] = produse[i].denumire;
            }
            nr = 16;
        }

        private void FormGrafic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle area = e.ClipRectangle;
            Brush background = new SolidBrush(Color.Black);

            g.FillRectangle(background, area);
            area.Height -= 40;

            int vl = area.Left, vr = area.Right, vt = area.Top, vb = area.Bottom;

            int lat, dist;
            float rap_dis_lat = 0.25f, max;

            SolidBrush[] pensule = new SolidBrush[]
            {
                new SolidBrush(Color.Red), new SolidBrush(Color.OrangeRed), new SolidBrush(Color.Orange), new SolidBrush(Color.Gold),
                new SolidBrush(Color.Yellow), new SolidBrush(Color.Chartreuse), new SolidBrush(Color.YellowGreen), new SolidBrush(Color.Green),
                new SolidBrush(Color.Aqua), new SolidBrush(Color.Teal), new SolidBrush(Color.LightBlue), new SolidBrush(Color.Blue),
                new SolidBrush(Color.BlueViolet), new SolidBrush(Color.Purple), new SolidBrush(Color.Fuchsia), new SolidBrush(Color.Magenta)
            };

            SolidBrush pensulaCurenta;
            lat = (int)((vr - vl) / (int)((nr + 1) * rap_dis_lat + nr) * 0.95);
            dist = (int)(lat * rap_dis_lat);

            int i;
            for (max = preturi[0], i = 1; i < nr; i++)
                if (max < preturi[i]) max = preturi[i];
            for (i = 0; i < nr; i++)
            {
                pensulaCurenta = pensule[i % pensule.Length];
                PointF pnt = new PointF(
                    vl + i * (lat + dist + 5) + rap_dis_lat + dist,
                    vb - 0.95f * preturi[i] * (vb - vt) / max);

                SizeF sz = new SizeF(
                    lat, 0.95f * preturi[i] * (vb - vt) / max);
                g.FillRectangle(pensulaCurenta, new RectangleF(pnt, sz));
                g.DrawString(denumiri[i], Font, pensulaCurenta, vl + 15 + i * (lat + dist + 5), vb + 10);
                FontFamily fontPreturi = new FontFamily("Microsoft Sans Serif");
                Font font = new Font(fontPreturi, 13, FontStyle.Regular, GraphicsUnit.Pixel);
                g.DrawString(preturi[i].ToString(), font, pensulaCurenta, vl + 15 + i * (lat + dist + 5), vb - 0.95f * preturi[i] * (vb - vt) / max - 20);
            }
        }
    }
}
