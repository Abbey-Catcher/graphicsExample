using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphicsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            //pen for outline
            //brush for filling

            //pen (color, lineWidth)
            Pen redPen = new Pen(Color.Red, 15);
            //Brush (color)
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush redBrush  = new SolidBrush(Color.Red);  

            g.Clear(Color.White);

            //first 2 #'s - Starting point
            //last 2 #'s - ending point
            //draws line
            g.DrawLine(redPen, 0, 0, 100, 100);
            
            //30, 30: starting point
            //200 wide; 100 tall
            //draws ractangle
            g.DrawLine(redPen, 30, 30, 200, 100);

            //fill rectangle
            g.FillRectangle(blueBrush, 30, 30, 200, 100);

            //draw ellipse/circle
            g.DrawEllipse(redPen, 30, 30, 200, 200);
            g.FillEllipse(greenBrush, 30, 30, 200, 200);

            //250, 20: Starting point
            //50: length & width
            //30: Strating angle?
            //300 degree it draws for
            g.DrawArc(redPen, 250, 20, 50, 50, 30, 300);

            g.DrawPie(redPen, 250, 100, 50, 50, 30, 300);

            //Logo practice
            g.Clear(Color.White);
            Font logoFont = new Font("Arial", 16, FontStyle.Bold);

            //outer circle
            g.DrawEllipse(redPen, 30, 30, 100, 100);
            //inner circle
            g.DrawEllipse(redPen, 63, 63, 35, 35);
            g.FillEllipse(redBrush, 70, 70, 25, 25);

            g.TranslateTransform(150, 125);
            g.RotateTransform(270);
            g.DrawString("Target", logoFont, redBrush, 0, 0);
            g.ResetTransform();
        }
    }
}
