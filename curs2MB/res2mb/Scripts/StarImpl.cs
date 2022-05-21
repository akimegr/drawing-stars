using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWord = Microsoft.Office.Interop.Word;

namespace res2mb.Scripts
{
    class StarImpl : Star
    {

        public override PointF[] Calculate5StarPoints(PointF pointsTwo, float outerradius, float innerradius)
        {
            double Ang36 = Math.PI / 5.0; // 36° x PI/180
            double Ang72 = 2.0 * Ang36; // 72° x PI/180
            float Sin36 = (float)Math.Sin(Ang36);
            float Sin72 = (float)Math.Sin(Ang72);
            float Cos36 = (float)Math.Cos(Ang36);
            float Cos72 = (float)Math.Cos(Ang72);

            PointF[] myPoints = { pointsTwo, pointsTwo, pointsTwo, pointsTwo, pointsTwo, pointsTwo, pointsTwo, pointsTwo, pointsTwo, pointsTwo };
            myPoints[0].Y -= outerradius; //верх звезды 00 00
            myPoints[1].X += innerradius * Sin36; myPoints[1].Y -= innerradius * Cos36; // 0:06 часов
            myPoints[2].X += outerradius * Sin72; myPoints[2].Y -= outerradius * Cos72; // 0:12 часов
            myPoints[3].X += innerradius * Sin72; myPoints[3].Y += innerradius * Cos72; // 0:18
            myPoints[4].X += outerradius * Sin36; myPoints[4].Y += outerradius * Cos36; // 0:24
            myPoints[5].Y += innerradius;
            myPoints[6].X += myPoints[6].X - myPoints[4].X; myPoints[6].Y = myPoints[4].Y; // отражаем
            myPoints[7].X += myPoints[7].X - myPoints[3].X; myPoints[7].Y = myPoints[3].Y; // отражаем
            myPoints[8].X += myPoints[8].X - myPoints[2].X; myPoints[8].Y = myPoints[2].Y; // отражаем
            myPoints[9].X += myPoints[9].X - myPoints[1].X; myPoints[9].Y = myPoints[1].Y; // отражаем
            return myPoints;
        }

        public override void DrawStarGi(RadioButton var1, RadioButton var2, RadioButton var3, RadioButton var4, float widthDraw, float heighDraw, Button colorStars, ref Graphics[] G, int i, int maxValueC, bool checkMax, int colW)
        {
            while (checkMax && i < maxValueC)
            {
                if (var1.Checked)
                {
                    PointF[] Star1 = Calculate5StarPoints(new PointF(widthDraw, heighDraw), Radius1, Radius2);   //(x,y), длина внеешнего, длина внутреннего радиуса (50,20 топ)
                    SolidBrush FillBrush = new SolidBrush(colorStars.BackColor); //Внутренняя закраска
                    G[i].FillPolygon(FillBrush, Star1);
                    G[i].DrawPolygon(new Pen(Color.Purple, 5), Star1); //обводка
                }

                if (var2.Checked)   //клетка
                {
                    PointF[] Star2 = Calculate5StarPoints(new PointF(widthDraw, heighDraw), Radius1, Radius2);
                    HatchBrush pat = new HatchBrush(HatchStyle.Cross, Color.RosyBrown, colorStars.BackColor);
                    G[i].FillPolygon(pat, Star2);
                }

                if (var3.Checked)
                {
                    PointF[] Star3 = Calculate5StarPoints(new PointF(widthDraw, heighDraw), Radius1, Radius2);
                    LinearGradientBrush lin = new LinearGradientBrush(new System.Drawing.Point(350, 100), new System.Drawing.Point(350, 500), colorStars.BackColor, Color.Cyan);
                    G[i].FillPolygon(lin, Star3);
                }

                if (var4.Checked)
                {
                    PointF[] Star4 = Calculate5StarPoints(new PointF(widthDraw, heighDraw), Radius1, Radius2);
                    G[i].DrawPolygon(new Pen(colorStars.BackColor, 3), Star4);
                }
                if (maxValueC > 1)      //смещам кажду звезду вправо
                {
                    widthDraw += (float)(2 *Radius1 + 0.05 * Radius1);
                }
                i++;
                if (maxValueC > 1)      //вверх
                {
                    if (i % colW == 0)
                    {
                        heighDraw -= (float)2.25 * Radius1;
                        widthDraw = (float)(1.25 * Radius1);
                    }

                }
            }
        }

        public override void ShowAllVariantsStars()
        {
            System.Diagnostics.Process.Start(@"C:\Users\akime\OneDrive\Рабочий стол\4 КУРС МОЙ\varStars.docx");
        }

        public override float chooseDirection(RadioButton r1, RadioButton l1, RadioButton h1, RadioButton le1)
        {
            if (r1.Checked)
            {
                Direction = 0f;
            }
            if (l1.Checked)
            {
                Direction = -360f;
            }
            if (h1.Checked)
            {
                Direction = 360f;
            }
            if (le1.Checked)
            {
                Direction = -0f;
            }
            return Direction;
        }

        public override void printInWord(MyWord._Application wordApplicationForRun, PictureBox pictureBox1)
        {
            wordApplicationForRun = new MyWord.Application(); // объект чтобы открыть ворд
            string name = AppDomain.CurrentDomain.BaseDirectory;                                                    //это в класс как базу
            MyWord.Document wordDoc = wordApplicationForRun.Documents.Add();
            Range docRange = wordDoc.Range();
            docRange.Text = "Курсовая Егор Акимов\n\n\n";
            string imageName = name + "res.jpeg";
            string namez = AppDomain.CurrentDomain.BaseDirectory + "MyWordDoc2.docx";
            Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);
            bmp.Save(name + "res.jpeg");
            //pictureBox1.Image.Save(name + "MyWordDoc.png");
            InlineShape pictureShape = docRange.InlineShapes.AddPicture(imageName);

            wordDoc.SaveAs2(namez);
            wordApplicationForRun.Quit();
        }
    }
}
