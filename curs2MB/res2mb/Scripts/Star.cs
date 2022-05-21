using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWord = Microsoft.Office.Interop.Word;

namespace res2mb.Scripts
{
    abstract class Star
    {
        
        private string wordDocName = AppDomain.CurrentDomain.BaseDirectory + "MyWordDoc2.docx";
        private string baseDomain = AppDomain.CurrentDomain.BaseDirectory;
        public string WordDocName { get => wordDocName; set => wordDocName = value; }
        private float radius;
        private float radius2;
        private float direction;

        public float Radius1 { get => radius; set => radius = value; }
        public float Radius2 { get => radius2; set => radius2 = value; }
        public float Direction { get => direction; set => direction = value; }


        public abstract PointF[] Calculate5StarPoints(PointF Orig, float outerradius, float innerradius);
        public abstract void DrawStarGi(RadioButton var1, RadioButton var2, RadioButton var3, RadioButton var4, float widthDraw, float heighDraw, Button colorStars, ref Graphics[] G, int i, int maxValueC, bool checkMax, int colW);
        public abstract void ShowAllVariantsStars();
        public abstract float chooseDirection(RadioButton r1, RadioButton l1, RadioButton h1, RadioButton le1);
        public abstract void printInWord(MyWord._Application wordApplicationForRun, PictureBox pictureBox1);
    }
}
