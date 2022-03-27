using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace res2mb
{
    public partial class Form2 : Form
    {
        bool mode = true;
        private PictureBox pictureBox1 = new PictureBox();
        public Form2()
        {
            InitializeComponent();
            //InitializeComponent
            this.Text = "Курсовая Акимов Егор";
            //this.Size = new Size(6000, 600);

            //this.SuspendLayout();

            //this.ClientSize = new System.Drawing.Size(1220, 580);
            //this.Name = "DrawingForm";
            //this.Load += new System.EventHandler(this.DrawingForm_Load);
            //this.ResumeLayout(false);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void MyPainting(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            if (mode)
            {
                PointF[] Star1 = Calculate5StarPoints(new PointF(this.Width / 2, this.Height / 2), 100f, 50f);   //(x,y), длина внеешнего, длина внутреннего радиуса (50,20 топ)
                SolidBrush FillBrush = new SolidBrush(Color.White); //Внутренняя закраска
                G.FillPolygon(FillBrush, Star1);
                G.DrawPolygon(new Pen(Color.Purple, 5), Star1); //обводка
            }
            else
            {
                G.Clear(Color.Green);
            }

            //PointF[] Star2 = Calculate5StarPoints(new PointF(200f, 150f), 100f, 20f);
            //HatchBrush pat = new HatchBrush(HatchStyle.Cross, Color.RosyBrown, Color.IndianRed);
            //G.FillPolygon(pat, Star2);

            //PointF[] Star3 = Calculate5StarPoints(new PointF(350f, 300f), 200f, 100f);
            //LinearGradientBrush lin = new LinearGradientBrush(new Point(350, 100), new Point(350, 500),
            //Color.Salmon, Color.Cyan);
            //G.FillPolygon(lin, Star3);

            //PointF[] Star4 = Calculate5StarPoints(new PointF(140f, 400f), 120f, 10f);
            //G.DrawPolygon(new Pen(Color.LightSalmon, 3), Star4);
            if (!mode)
            {
                G.Clear(Color.Black);
            }
        }
        private PointF[] Calculate5StarPoints(PointF Orig, float outerradius, float innerradius)
        {
            double Ang36 = Math.PI / 5.0; // 36° x PI/180
            double Ang72 = 2.0 * Ang36; // 72° x PI/180 в лайфхакере так
            float Sin36 = (float)Math.Sin(Ang36);
            float Sin72 = (float)Math.Sin(Ang72);
            float Cos36 = (float)Math.Cos(Ang36);
            float Cos72 = (float)Math.Cos(Ang72);

            PointF[] pnts = { Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig };
            pnts[0].Y -= outerradius; // top off the star, or on a clock this is 12:00 or 0:00 hours
            pnts[1].X += innerradius * Sin36; pnts[1].Y -= innerradius * Cos36; // 0:06 hours
            pnts[2].X += outerradius * Sin72; pnts[2].Y -= outerradius * Cos72; // 0:12 hours
            pnts[3].X += innerradius * Sin72; pnts[3].Y += innerradius * Cos72; // 0:18
            pnts[4].X += outerradius * Sin36; pnts[4].Y += outerradius * Cos36; // 0:24
            pnts[5].Y += innerradius;
            pnts[6].X += pnts[6].X - pnts[4].X; pnts[6].Y = pnts[4].Y; // mirror point
            pnts[7].X += pnts[7].X - pnts[3].X; pnts[7].Y = pnts[3].Y; // mirror point
            pnts[8].X += pnts[8].X - pnts[2].X; pnts[8].Y = pnts[2].Y; // mirror point
            pnts[9].X += pnts[9].X - pnts[1].X; pnts[9].Y = pnts[1].Y; // mirror point
            return pnts;
        }
        private void DrawingForm_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mode = !mode;
            if (mode)
            {
                draw.Text = "СМЕНИТЬ ЗВЕЗДУ";
                typeStars.Visible = false;
                sizeStars.Visible = false;
                sizeStarsNumber.Visible = false;
                variants.Visible = false;
                colorStars.Visible = false;
                pictureBox1.Dock = DockStyle.Fill;
                pictureBox1.BackColor = Color.White;
                // Connect the Paint event of the PictureBox to the event handler method.
                pictureBox1.Visible = true;
                pictureBox1.Paint += new PaintEventHandler(MyPainting);
                this.Controls.Add(pictureBox1);
                this.SuspendLayout();

                //this.ClientSize = new System.Drawing.Size(1220, 580);
                //this.Name = "DrawingForm";
                //this.Load += new System.EventHandler(this.DrawingForm_Load);
                this.ResumeLayout(false);

            }
            else
            {
                draw.Text = "НАРИСОВАТЬ";
                typeStars.Visible = true;
                sizeStars.Visible = true;
                sizeStarsNumber.Visible = true;
                variants.Visible = true;
                colorStars.Visible = true;
                pictureBox1.Visible = false;
            }
        
        }
    }
}
