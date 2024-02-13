using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_PrototipoMenu
{
    public partial class frmRenovacion : Form
    {
        public frmRenovacion()
        {

            InitializeComponent();



            textBox1.MouseClick += textBox1_MouseClick;
            textBox2.MouseClick += textBox2_MouseClick;

            textBox1.Text = "-----";
            textBox2.Text = "-----";
            panel1.Paint += panel1_Paint;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;

     
            Pen borde = new Pen(Color.Black, 2);

            int radio = 10; 
            Rectangle rectangulo = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);

            g.DrawArc(borde, rectangulo.X, rectangulo.Y, radio * 2, radio * 2, 180, 90);
            g.DrawLine(borde, rectangulo.X + radio, rectangulo.Y, rectangulo.X + rectangulo.Width - radio, rectangulo.Y);
            g.DrawArc(borde, rectangulo.X + rectangulo.Width - radio * 2, rectangulo.Y, radio * 2, radio * 2, 270, 90);
            g.DrawLine(borde, rectangulo.X + rectangulo.Width, rectangulo.Y + radio, rectangulo.X + rectangulo.Width, rectangulo.Y + rectangulo.Height - radio);
            g.DrawArc(borde, rectangulo.X + rectangulo.Width - radio * 2, rectangulo.Y + rectangulo.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            g.DrawLine(borde, rectangulo.X + radio, rectangulo.Y + rectangulo.Height, rectangulo.X + rectangulo.Width - radio, rectangulo.Y + rectangulo.Height);
            g.DrawArc(borde, rectangulo.X, rectangulo.Y + rectangulo.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            g.DrawLine(borde, rectangulo.X, rectangulo.Y + radio, rectangulo.X, rectangulo.Y + rectangulo.Height - radio);

            borde.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "-----")
            {
                textBox1.Text = string.Empty;
            }


        }

        private void textBox2_MouseClick(object sender, EventArgs e)
        {
            if (textBox2.Text == "-----")
            {
                textBox2.Text = string.Empty;
            }


        }
    }
}
