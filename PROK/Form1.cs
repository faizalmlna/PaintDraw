using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaintDrawX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                DrawBasketball(g);
                DrawNama(g);
            }
        }

        private void DrawBasketball(Graphics g)
        {
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int radius = 100;

            Rectangle rect = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);

            using (Pen orangePen = new Pen(Color.Orange, 2))
            using (Pen blackPen = new Pen(Color.Black, 3))
            {
                g.FillEllipse(new SolidBrush(Color.Orange), rect);
                g.DrawEllipse(blackPen, rect);
                g.DrawLine(blackPen, centerX - radius, centerY, centerX + radius, centerY);
                g.DrawLine(blackPen, centerX, centerY - radius, centerX, centerY + radius);
                g.DrawArc(blackPen, centerX - radius, centerY - radius / 2, 2 * radius, radius, 0, 180);
                g.DrawArc(blackPen, centerX - radius, centerY - radius / 2, 2 * radius, radius, 180, 180);
                g.DrawArc(blackPen, centerX - radius / 2, centerY - radius, radius, 2 * radius, 90, 180);
                g.DrawArc(blackPen, centerX - radius / 2, centerY - radius, radius, 2 * radius, 270, 180);
            }
        }

        private void DrawNama(Graphics g)
        {
            using (Pen pen = new Pen(Color.Black, 2))
            {
                int centerX = this.ClientSize.Width / 2;
                int centerY = this.ClientSize.Height / 2;
                int radius = 100;
                int startX = centerX - 150;
                int startY = centerY + radius + 20;
                int letterSpacing = 20;

                // Huruf 'F'
                g.DrawLine(pen, startX, startY, startX, startY + 50);
                g.DrawLine(pen, startX, startY, startX + 30, startY); 
                g.DrawLine(pen, startX, startY + 25, startX + 20, startY + 25); 

                startX += 50 + letterSpacing;

                // Draw 'A'
                g.DrawLine(pen, startX, startY + 50, startX + 15, startY);
                g.DrawLine(pen, startX + 15, startY, startX + 30, startY + 50); 
                g.DrawLine(pen, startX + 8, startY + 25, startX + 22, startY + 25);

                startX += 50 + letterSpacing;

                // Huruf 'I'
                g.DrawLine(pen, startX + 15, startY, startX + 15, startY + 50); 
                g.DrawLine(pen, startX, startY, startX + 30, startY); 
                g.DrawLine(pen, startX, startY + 50, startX + 30, startY + 50); 

                startX += 50 + letterSpacing;

                // Huruf 'Z'
                g.DrawLine(pen, startX, startY, startX + 30, startY); 
                g.DrawLine(pen, startX + 30, startY, startX, startY + 50); 
                g.DrawLine(pen, startX, startY + 50, startX + 30, startY + 50); 

                startX += 50 + letterSpacing;

                // Huruf 'A'
                g.DrawLine(pen, startX, startY + 50, startX + 15, startY); 
                g.DrawLine(pen, startX + 15, startY, startX + 30, startY + 50); 
                g.DrawLine(pen, startX + 8, startY + 25, startX + 22, startY + 25);

                startX += 50 + letterSpacing;

                // Huruf 'L'
                g.DrawLine(pen, startX, startY, startX, startY + 50); 
                g.DrawLine(pen, startX, startY + 50, startX + 30, startY + 50); 
            }
        }
    }
}
