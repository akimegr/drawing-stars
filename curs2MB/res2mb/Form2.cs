using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MyWord = Microsoft.Office.Interop.Word;
using Xceed.Words.NET;
using Xceed.Document.NET;
using Microsoft.Office.Interop.Word;
using System.Threading;

namespace res2mb
{
    public partial class Form2 : Form
    {

        bool mode = false;
        float radius;
        float radius2;
        private PictureBox pictureBox1;
        int colW;
        int colH;
        Thread tred2;
        private MyWord._Application wordApplicationForRun;
        ClassLibrary1.Class1 s = new ClassLibrary1.Class1();

        public Form2()
        {
            InitializeComponent();
            tred2 = new Thread(s.show);
            //InitializeComponent
            this.Text = "Курсовая Акимов Егор";
            this.Size = new Size(943, 577);

            //this.SuspendLayout();

            //this.ClientSize = new System.Drawing.Size(1220, 580);
            //this.Name = "DrawingForm";
            //this.Load += new System.EventHandler(this.DrawingForm_Load);
            //this.ResumeLayout(false);
            //directx
            //dll
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void MyPainting(object sender, PaintEventArgs e)
        {

            int maxValueC = int.Parse(maxValue.Text);
            Graphics[] G = new Graphics[maxValueC];
            for (int z = 0; z < maxValueC; z++)
            {
                G[z] = e.Graphics;
                G[z].SmoothingMode = SmoothingMode.HighQuality;
                G[z].Clear(Color.White);
            }
            bool checkMax = true;
            if (maxValueC == 1)
            {
                checkMax = true;
            }
            else
            {
                if (int.Parse(sizeStarsNumber.Text) <= 350)
                {
                    checkMax = true;
                }
                else
                {
                    checkMax = false;
                    MessageBox.Show("При значении больше 1 звезды их величина должна быть меньше 350");
                    draw.Text = "НАРИСОВАТЬ";
                    typeStars.Visible = true;
                    sizeStars.Visible = true;
                    groupBox1.Visible = true;
                    sizeStarsNumber.Visible = true;
                    variants.Visible = true;
                    colorStars.Visible = true;
                    label1.Visible = true;
                    maxValue.Visible = true;
                    button4.Visible = true;
                    button1.Visible = true;
                    button3.Visible = true;
                    h1.Visible = true;
                    r1.Visible = true;
                    le1.Visible = true;
                    l1.Visible = true;
                    pictureBox1.Dispose();
                }


            }
            if (mode)
            {
                radius = float.Parse(sizeStarsNumber.Text);
                radius2 = (float)(radius / 2.5);
                float widthDraw;
                float heighDraw;


                if (maxValueC > 1)
                {

                    colW = (int)((this.Width-40) / (2*radius));
                    colH = (int)((this.Height -100)/ (2*radius+30));
                    
                        heighDraw = (float)(this.Height - 1 * radius-45);
                        widthDraw = (float)(0 + 1*radius);

                }
                else
                {
                    colW = 1;
                    colH = 1;
                    widthDraw = (float)(this.Width / 2);
                    heighDraw = (float)(this.Height / 2);
                }
                int i = 0;
                while (checkMax && i < maxValueC)
                {
                    try
                    {


                        if (var1.Checked)
                        {
                            PointF[] Star1 = Calculate5StarPoints(new PointF(widthDraw, heighDraw), radius, radius2);   //(x,y), длина внеешнего, длина внутреннего радиуса (50,20 топ)
                            SolidBrush FillBrush = new SolidBrush(colorStars.BackColor); //Внутренняя закраска
                            G[i].FillPolygon(FillBrush, Star1);
                            G[i].DrawPolygon(new Pen(Color.Purple, 5), Star1); //обводка
                        }

                        if (var2.Checked)
                        {
                            PointF[] Star2 = Calculate5StarPoints(new PointF(widthDraw, heighDraw), radius, radius2);
                            HatchBrush pat = new HatchBrush(HatchStyle.Cross, Color.RosyBrown, colorStars.BackColor);
                            G[i].FillPolygon(pat, Star2);
                        }

                        if (var3.Checked)
                        {
                            PointF[] Star3 = Calculate5StarPoints(new PointF(widthDraw, heighDraw), radius, radius2);
                            LinearGradientBrush lin = new LinearGradientBrush(new System.Drawing.Point(350, 100), new System.Drawing.Point(350, 500), colorStars.BackColor, Color.Cyan);
                            G[i].FillPolygon(lin, Star3);
                        }

                        if (var4.Checked)
                        {
                            PointF[] Star4 = Calculate5StarPoints(new PointF(widthDraw, heighDraw), radius, radius2);
                            G[i].DrawPolygon(new Pen(colorStars.BackColor, 3), Star4);
                        }
                        if (maxValueC > 1)      //смещам кажду звезду вправо
                        {
                            widthDraw += (float)(2 * radius + 0.05*radius);
                        }


                    }
                    catch (Exception ez)
                    {
                        MessageBox.Show("Введите верное значение");
                        pictureBox1.Visible = false;
                        draw.Text = "НАРИСОВАТЬ";
                        typeStars.Visible = true;
                        sizeStars.Visible = true;
                        groupBox1.Visible = true;
                        sizeStarsNumber.Visible = true;
                        variants.Visible = true;
                        colorStars.Visible = true;
                        button4.Visible = true;
                        button1.Visible = true;
                        button3.Visible = true;
                        h1.Visible = true;
                        r1.Visible = true;
                        le1.Visible = true;
                        l1.Visible = true;
                        button1.Visible = true;
                        pictureBox1.Visible = false;
                        label1.Visible = false;
                        maxValue.Visible = false;
                        break;
                    }
                    i++;
                    if (maxValueC > 1)
                    {
                        if (i % colW == 0)
                        {
                            heighDraw -= (float)2.25 * radius;
                            widthDraw = (float)(1.25 * radius);
                        }

                    }
                }
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
            //try
            //{
            //    radius = float.Parse(sizeStarsNumber.Text);
            //    radius2 = (float)(radius / 2.5);
            //    if ((Width-15) / (2 * radius) * ((Height - 140) / (2 * radius)) < Double.Parse(maxValue.Text)){
            //        throw new Exception("Не поместятся");
            //    }
            //    mode = !mode;
            //    if (mode)
            //    {
            //        pictureBox1 = new PictureBox();
            //        draw.Text = "СМЕНИТЬ ЗВЕЗДУ";
            //        typeStars.Visible = false;
            //        sizeStars.Visible = false;
            //        groupBox1.Visible = false;
            //        sizeStarsNumber.Visible = false;
            //        variants.Visible = false;
            //        colorStars.Visible = false;
            //        button1.Visible = false;
            //        label1.Visible = false;
            //        maxValue.Visible = false;
            //        button4.Visible = false;
            //        button1.Visible = false;
            //        button3.Visible = false;
            //        h1.Visible = false;
            //        r1.Visible = false;
            //        le1.Visible = false;
            //        l1.Visible = false;
            //        pictureBox1.Dock = DockStyle.Fill;
            //        pictureBox1.BackColor = Color.White;
            //        // Connect the Paint event of the PictureBox to the event handler method.
            //        pictureBox1.Visible = true;
            //        int z = 0;
            //        pictureBox1.Paint += new PaintEventHandler(MyPainting);
            //        this.Controls.Add(pictureBox1);

            //        wordApplicationForRun = new MyWord.Application(); // объект чтобы открыть ворд
            //        string name = AppDomain.CurrentDomain.BaseDirectory;
            //        MyWord.Document wordDoc = wordApplicationForRun.Documents.Add();
            //        Range docRange = wordDoc.Range();
            //        docRange.Text = "Курсовая Егор Акимов\n\n\n";
            //        string imageName = name + "res.jpeg";
            //        string namez = AppDomain.CurrentDomain.BaseDirectory + "MyWordDoc2.docx";
            //        Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            //        pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);
            //        bmp.Save(name + "res.jpeg");
            //        //pictureBox1.Image.Save(name + "MyWordDoc.png");
            //        InlineShape pictureShape = docRange.InlineShapes.AddPicture(imageName);

            //        wordDoc.SaveAs2(namez);
            //        wordApplicationForRun.Quit();

            //        this.SuspendLayout();

            //        //this.ClientSize = new System.Drawing.Size(1220, 580);
            //        //this.Name = "DrawingForm";
            //        //this.Load += new System.EventHandler(this.DrawingForm_Load);
            //        this.ResumeLayout(false);

            //    }
            //    else
            //    {
            //        draw.Text = "НАРИСОВАТЬ";
            //        typeStars.Visible = true;
            //        sizeStars.Visible = true;
            //        sizeStarsNumber.Visible = true;
            //        variants.Visible = true;
            //        colorStars.Visible = true;
            //        button1.Visible = true;
            //        label1.Visible = true;
            //        maxValue.Visible = true;
            //        groupBox1.Visible = true;
            //        button4.Visible = true;
            //        button1.Visible = true;
            //        button3.Visible = true;
            //        h1.Visible = true;
            //        r1.Visible = true;
            //        le1.Visible = true;
            //        l1.Visible = true;
            //        pictureBox1.Dispose();
            //    }
            //}
            //catch(Exception fe)
            //{
            //    MessageBox.Show(fe.Message);
            //}

        }

        private void colorStars_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (tred2.IsAlive)
            { 
                tred2.Resume();
                button1.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = true;
            }

            else
            {
                if (double.Parse(sizeStarsNumber.Text) <= 500 && double.Parse(sizeStarsNumber.Text) >= 115)
                {
                    float direction = 0f;
                    if (r1.Checked)
                    {
                        direction = 0f;
                    }
                    if (l1.Checked)
                    {
                        direction = -360f;
                    }
                    if (h1.Checked)
                    {
                        direction = 360f;
                    }
                    if (le1.Checked)
                    {
                        direction = -0f;
                    }

                    button1.Enabled = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    ClassLibrary1.Class1 s = new ClassLibrary1.Class1();
                    string forThred = sizeStarsNumber.Text + "|" + direction;
                    tred2 = new Thread(s.show);
                    tred2.Start(forThred);
                    //s.show(float.Parse(sizeStarsNumber.Text));
                }
                else
                {
                    MessageBox.Show("Макимальный размер 500. Минимальный для Сириуса 115");
                }
            }
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string namez = AppDomain.CurrentDomain.BaseDirectory + "MyWordDoc2.docx";

            System.Diagnostics.Process.Start(namez);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tred2.Suspend(); //остановит, если остановит то ничего
            button1.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tred2.Abort();//вызовет ошибку которая остановит поток
            button3.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа Егора Акимова. Рисование звёзд. \n \tСейчас " + DateTime.Now);
        }

        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                radius = float.Parse(sizeStarsNumber.Text);
                radius2 = (float)(radius / 2.5);
                if ((Width - 15) / (2 * radius) * ((Height - 140) / (2 * radius)) < Double.Parse(maxValue.Text))
                {
                    throw new Exception("Не поместятся");
                }
                mode = !mode;
                if (mode)
                {
                    pictureBox1 = new PictureBox();
                    drawToolStripMenuItem.Text = "СМЕНИТЬ ЗВЕЗДУ";
                    typeStars.Visible = false;
                    sizeStars.Visible = false;
                    groupBox1.Visible = false;
                    sizeStarsNumber.Visible = false;
                    variants.Visible = false;
                    colorStars.Visible = false;
                    button1.Visible = false;
                    label1.Visible = false;
                    maxValue.Visible = false;
                    button4.Visible = false;
                    button1.Visible = false;
                    button3.Visible = false;
                    h1.Visible = false;
                    r1.Visible = false;
                    le1.Visible = false;
                    l1.Visible = false;
                    pictureBox1.Dock = DockStyle.Fill;
                    pictureBox1.BackColor = Color.White;
                    // Connect the Paint event of the PictureBox to the event handler method.
                    pictureBox1.Visible = true;
                    int z = 0;
                    pictureBox1.Paint += new PaintEventHandler(MyPainting);
                    this.Controls.Add(pictureBox1);

                    wordApplicationForRun = new MyWord.Application(); // объект чтобы открыть ворд
                    string name = AppDomain.CurrentDomain.BaseDirectory;
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

                    this.SuspendLayout();

                    //this.ClientSize = new System.Drawing.Size(1220, 580);
                    //this.Name = "DrawingForm";
                    //this.Load += new System.EventHandler(this.DrawingForm_Load);
                    this.ResumeLayout(false);

                }
                else
                {
                    drawToolStripMenuItem.Text = "НАРИСОВАТЬ";
                    typeStars.Visible = true;
                    sizeStars.Visible = true;
                    sizeStarsNumber.Visible = true;
                    variants.Visible = true;
                    colorStars.Visible = true;
                    button1.Visible = true;
                    label1.Visible = true;
                    maxValue.Visible = true;
                    groupBox1.Visible = true;
                    button4.Visible = true;
                    button1.Visible = true;
                    button3.Visible = true;
                    h1.Visible = true;
                    r1.Visible = true;
                    le1.Visible = true;
                    l1.Visible = true;
                    pictureBox1.Dispose();
                }
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string namez = AppDomain.CurrentDomain.BaseDirectory + "MyWordDoc2.docx";

            System.Diagnostics.Process.Start(namez);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            r1.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            h1.Checked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            le1.Checked = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            l1.Checked = true;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа Егора Акимова. Рисование звёзд. \n \tСейчас " + DateTime.Now);

        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Программа Егора Акимова. Рисование звёзд. \n \tСейчас " + DateTime.Now);
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                radius = float.Parse(sizeStarsNumber.Text);
                radius2 = (float)(radius / 2.5);
                if ((Width - 15) / (2 * radius) * ((Height - 140) / (2 * radius)) < Double.Parse(maxValue.Text))
                {
                    throw new Exception("Не поместятся");
                }
                mode = !mode;
                if (mode)
                {
                    pictureBox1 = new PictureBox();
                    drawToolStripMenuItem.Text = "СМЕНИТЬ ЗВЕЗДУ";
                    typeStars.Visible = false;
                    sizeStars.Visible = false;
                    groupBox1.Visible = false;
                    sizeStarsNumber.Visible = false;
                    variants.Visible = false;
                    colorStars.Visible = false;
                    button1.Visible = false;
                    label1.Visible = false;
                    maxValue.Visible = false;
                    button4.Visible = false;
                    button1.Visible = false;
                    button3.Visible = false;
                    h1.Visible = false;
                    r1.Visible = false;
                    le1.Visible = false;
                    l1.Visible = false;
                    pictureBox1.Dock = DockStyle.Fill;
                    pictureBox1.BackColor = Color.White;
                    // Connect the Paint event of the PictureBox to the event handler method.
                    pictureBox1.Visible = true;
                    int z = 0;
                    pictureBox1.Paint += new PaintEventHandler(MyPainting);
                    this.Controls.Add(pictureBox1);

                    wordApplicationForRun = new MyWord.Application(); // объект чтобы открыть ворд
                    string name = AppDomain.CurrentDomain.BaseDirectory;
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

                    this.SuspendLayout();

                    //this.ClientSize = new System.Drawing.Size(1220, 580);
                    //this.Name = "DrawingForm";
                    //this.Load += new System.EventHandler(this.DrawingForm_Load);
                    this.ResumeLayout(false);

                }
                else
                {
                    drawToolStripMenuItem.Text = "НАРИСОВАТЬ";
                    typeStars.Visible = true;
                    sizeStars.Visible = true;
                    sizeStarsNumber.Visible = true;
                    variants.Visible = true;
                    colorStars.Visible = true;
                    button1.Visible = true;
                    label1.Visible = true;
                    maxValue.Visible = true;
                    groupBox1.Visible = true;
                    button4.Visible = true;
                    button1.Visible = true;
                    button3.Visible = true;
                    h1.Visible = true;
                    r1.Visible = true;
                    le1.Visible = true;
                    l1.Visible = true;
                    pictureBox1.Dispose();
                }
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void helperToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, @"C:\Users\akime\OneDrive\Рабочий стол\4 КУРС МОЙ\РПВС ЛАБЫ\lab8\WindowsFormsApp1 — копия\WindowsFormsApp1\helph\NewProject.chm");
            Help.ShowHelp(this, @"C:\Users\akime\OneDrive\Документы\GitHub\drawing-stars\curs2MB\res2mb\helper\MMyNewNewProject.chm");
        }
    }
}
