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

namespace curs2MB
{
    public partial class Form1 : Form
    {
        res2mb.Form2 formLogical;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Курсовая Акимов Егор";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Visible = false;
            //label2.Visible = false;
            //label3.Visible = false;
            //button1.Visible = false;
            //this.BackgroundImage = null;
            //this.BackColor = Color.FromArgb(0, 0, 255);
            formLogical = new res2mb.Form2();
            this.Hide();
            formLogical.Show();
        }
    }
}

