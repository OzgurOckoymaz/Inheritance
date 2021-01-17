using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecPerimeter_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle();
            r.ShortEdge = Convert.ToDecimal(textBox1.Text);
            r.LongEdge = Convert.ToDecimal(textBox2.Text);
            MessageBox.Show($"The perimeter of the Rectangular is {r.Rec_Perimeter(r.ShortEdge, r.LongEdge)}");

            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnRecArea_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle();
            r.ShortEdge = Convert.ToDecimal(textBox1.Text);
            r.LongEdge = Convert.ToDecimal(textBox2.Text);
            MessageBox.Show($"The area of the rectangular is {r.Rec_Area(r.ShortEdge, r.LongEdge)}");

            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnSquPerimeter_Click(object sender, EventArgs e)
        {
            Square s = new Square();
            s.Edge = Convert.ToDecimal(textBox3.Text);
            MessageBox.Show($"The perimeter of the square is {s.Squ_Perimeter(s.Edge)}");

            textBox3.Clear();
        }

        private void btnSquArea_Click(object sender, EventArgs e)
        {
            Square s = new Square();
            s.Edge = Convert.ToDecimal(textBox3.Text);
            MessageBox.Show($"The area of th square is {s.Squ_Area(s.Edge)}");

            textBox3.Clear();

        }
    }
}
