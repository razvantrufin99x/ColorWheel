using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ColorWheel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Pen p;
        Brush b;
        Font f;
        int dim = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            //p = new Pen(Color.Black, dim);
            p = new Pen(Color.Black, 1);
            b = new SolidBrush(Color.Black);
            f = Font;

        }

        public void draw()
        {
            for (int pas = 0; pas < 23; pas++)
            {

                for (int i = 0; i < 256; i += dim)
                {
                    for (int j = 0; j < 256; j += dim)
                    {
                        for (int k = 0; k < 256; k += dim)
                        {
                            if(pas==0)
                                p.Color = Color.FromArgb(k, i, j);
                            if (pas == 1)
                                p.Color = Color.FromArgb(k, j, i);
                            if (pas == 2)
                                p.Color = Color.FromArgb(i, k, j);
                            if (pas == 3)
                                p.Color = Color.FromArgb(i, j, k);
                            if (pas == 4)
                                p.Color = Color.FromArgb(j, i, k);
                            if (pas == 5)
                                p.Color = Color.FromArgb(j, k, i);
                            if (pas == 6)
                                p.Color = Color.FromArgb(k, i, 0);
                            if (pas == 7)
                                p.Color = Color.FromArgb(k, j, 0);
                            if (pas == 8)
                                p.Color = Color.FromArgb(i, k, 0);
                            if (pas == 9)
                                p.Color = Color.FromArgb(i, j, 0);
                            if (pas == 10)
                                p.Color = Color.FromArgb(j, i, 0);
                            if (pas == 11)
                                p.Color = Color.FromArgb(j, k, 0);
                            if (pas == 12)
                                p.Color = Color.FromArgb(0,k, i);
                            if (pas == 13)
                                p.Color = Color.FromArgb(0,k, j);
                            if (pas == 14)
                                p.Color = Color.FromArgb(0,i, k);
                            if (pas == 15)
                                p.Color = Color.FromArgb(0,i, j);
                            if (pas == 16)
                                p.Color = Color.FromArgb(0,j, i);
                            if (pas == 17)
                                p.Color = Color.FromArgb(0,j, k);
                            if (pas == 18)
                                p.Color = Color.FromArgb(k, 0, j);
                            if (pas == 19)
                                p.Color = Color.FromArgb(k, 0, i);
                            if (pas == 20)
                                p.Color = Color.FromArgb(i, 0, j);
                            if (pas == 21)
                                p.Color = Color.FromArgb(i, 0, k);
                            if (pas == 22)
                                p.Color = Color.FromArgb(j, 0, k);
                            if (pas == 23)
                                p.Color = Color.FromArgb(j, 0, i);

                           // g.DrawEllipse(p, j, i, dim, dim);
                            //g.DrawEllipse(p, pas * (j / dim), pas * (i / dim), 5, 5);
                            g.FillEllipse(new SolidBrush(p.Color), j, i, dim, dim);
                            txtr.Text = i.ToString();
                            txtg.Text = j.ToString();
                            txtb.Text = k.ToString();
                            //Thread.Sleep(1);
                            txtr.Refresh();
                            txtg.Refresh();
                            txtb.Refresh();
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            draw();
        }
    }
}
