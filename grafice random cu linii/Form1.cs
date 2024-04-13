using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafice_random_cu_linii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r= new Random();
            for (int i = 1; i <= 10000; i++)
            {
                Color c = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                Pen p = new Pen(c);
                int x1=r.Next(this.Width);
                int y1=r.Next(this.Height);
                int x2=r.Next(this.Width);
                int y2 = r.Next(this.Height);

                g.DrawLine(p, x1, y1, x2, y2);
            }
        }
    }
}
