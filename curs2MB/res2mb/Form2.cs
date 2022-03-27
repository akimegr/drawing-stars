using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Diagnostics; 

namespace res2mb
{
    public partial class Form2 : Form
    {
        bool mode = false;
        private PictureBox pictureBox1;
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

            int maxValueC = int.Parse(maxValue.Text);
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.Clear(Color.White);
            bool checkMax = true;
            if (maxValueC == 1)
            {
                checkMax = true;
            }
            else
            {
                if (int.Parse(sizeStarsNumber.Text) <= 25)
                {
                    checkMax = true;
                }
                else
                {
                    checkMax = false;
                    MessageBox.Show("При значении больше 1 звезды их величина должна быть меньше 25");
                }
                

            }
            if (mode)
            {
                int i = 0;
                while (checkMax && i < maxValueC)
                {
                    try
                    {
                        float radius = float.Parse(sizeStarsNumber.Text);
                        float radius2 = (float)(radius / 2.5);

                        if (var1.Checked)
                        {
                            PointF[] Star1 = Calculate5StarPoints(new PointF(this.Width / 2, this.Height / 2), radius, radius2);   //(x,y), длина внеешнего, длина внутреннего радиуса (50,20 топ)
                            SolidBrush FillBrush = new SolidBrush(colorStars.BackColor); //Внутренняя закраска
                            G.FillPolygon(FillBrush, Star1);
                            G.DrawPolygon(new Pen(Color.Purple, 5), Star1); //обводка
                        }

                        if (var2.Checked)
                        {
                            PointF[] Star2 = Calculate5StarPoints(new PointF(this.Width / 2, this.Height / 2), radius, radius2);
                            HatchBrush pat = new HatchBrush(HatchStyle.Cross, Color.RosyBrown, colorStars.BackColor);
                            G.FillPolygon(pat, Star2);
                        }

                        if (var3.Checked)
                        {
                            PointF[] Star3 = Calculate5StarPoints(new PointF(this.Width / 2, this.Height / 2), radius, radius2);
                            LinearGradientBrush lin = new LinearGradientBrush(new Point(350, 100), new Point(350, 500), colorStars.BackColor, Color.Cyan);
                            G.FillPolygon(lin, Star3);
                        }

                        if (var4.Checked)
                        {
                            PointF[] Star4 = Calculate5StarPoints(new PointF(this.Width / 2, this.Height / 2), radius, radius2);
                            G.DrawPolygon(new Pen(colorStars.BackColor, 3), Star4);
                        }

                    }
                    catch (Exception ez)
                    {
                        MessageBox.Show("Введите верное значение");
                        pictureBox1.Visible = false;
                        draw.Text = "НАРИСОВАТЬ";
                        typeStars.Visible = true;
                        sizeStars.Visible = true;
                        sizeStarsNumber.Visible = true;
                        variants.Visible = true;
                        colorStars.Visible = true;
                        pictureBox1.Visible = false;
                        label1.Visible = false;
                        maxValue.Visible = false;
                        break;
                    }
                    i++;
                }
            }
            else
            {
                G.Clear(Color.Green);
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
                pictureBox1 = new PictureBox();
                draw.Text = "СМЕНИТЬ ЗВЕЗДУ";
                typeStars.Visible = false;
                sizeStars.Visible = false;
                sizeStarsNumber.Visible = false;
                variants.Visible = false;
                colorStars.Visible = false;
                                        label1.Visible = false;
                        maxValue.Visible = false;
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
                label1.Visible = true;
                maxValue.Visible = true;
                pictureBox1.Dispose();
            }

        }

        private void colorStars_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()!= DialogResult.Cancel)
            {
                colorStars.BackColor = colorDialog1.Color;
            }
        }

        private void variants_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"c:\Temp\Downloads\some.doc");
            System.Diagnostics.Process.Start(@"C:\Users\akime\OneDrive\Рабочий стол\4 КУРС МОЙ\varStars.docx");
        }

        private void maxValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
