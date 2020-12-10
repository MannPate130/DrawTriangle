using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTriangle
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Graphics g = this.CreateGraphics();

            Pen trianglePen = new Pen(Color.Black);

            int X1 = 50;
            int X2 = 100;
            int X3 = 200;
            int Y1 = 50;
            int Y2 = 50;
            int Y3 = 200;

        

        }
        public void DrawTriangle(Pen trianglePen, int X1, int X2, int X3, int Y1, int Y2, int Y3)
        {
            Graphics g = this.CreateGraphics();

            Point a = new Point(X1, Y1);
            Point b = new Point(X2, Y2);
            Point c = new Point(X3, Y3);

            g.DrawLine(trianglePen, a, b);

            g.DrawLine(trianglePen, b, c);

            g.DrawLine(trianglePen, c, a);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Pen trianglePen = new Pen(Color.Black);
           
            DrawTriangle(trianglePen, 50, 50, 250, 150, 50, 140);
        }
    }
}
