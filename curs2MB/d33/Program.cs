using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.FreeGlut;
using OpenGL;

namespace d33
{
    class Program
    {
        private static int width = 1280, height = 720;
        private static ShaderProgram program;
        private static VBO<Vector3> star;
        private static VBO<Vector3> starColor;
        private static VBO<uint> starTriangles;
        private static System.Diagnostics.Stopwatch watch;  //Для точно измерения времени
        private static float angle;
        static float deltaTime = 0.001f;

        public static void Main()
        {
            float max = 500;
            float take = 315;
            float res = take / max;

            ;
            // создаём окно опенжл
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);   //глубина и двойная буфризация
            Glut.glutInitWindowSize(width, height);
            Glut.glutCreateWindow("Курсовая Егор Акимов");

            //устанавливает глобальный обратный вызов простоя как func, 
            //чтобы программа GLUT могла выполнять задачи фоновой обработки или непрерывную анимацию, когда события оконной системы не принимаются.
            Glut.glutIdleFunc(OnRenderFrame);
            Glut.glutDisplayFunc(OnDisplay);
            Glut.glutCloseFunc(OnClose);

            // включить тестирование глубины, чтобы обеспечить правильное z-упорядочение наших фрагментов
            Gl.Enable(EnableCap.DepthTest);

            // скомпилировать программу-шейдер
            program = new ShaderProgram(VertexShader, FragmentShader);

            // установите матрицу вида и проекции, которые являются статическими на протяжении всего
            program.Use();
            program["projection_matrix"].SetValue(Matrix4.CreatePerspectiveFieldOfView(0.7f/res, (float)width / height, 0.1f, 1000f));  //размер
            program["view_matrix"].SetValue(Matrix4.LookAt(new Vector3(0, 0, 10), Vector3.Zero, new Vector3(0, 1, 0))); //под каким углом смотреть
            double Ang36 = Math.PI / 5.0; // 36° x PI/180
            double Ang72 = 2.0 * Ang36; // 72° x PI/180 в лайфхакере так
            float Sin36 = (float)Math.Sin(Ang36);
            float Sin72 = (float)Math.Sin(Ang72);
            float Cos36 = (float)Math.Cos(Ang36);
            float Cos72 = (float)Math.Cos(Ang72);

            // create a pyramid with vertices and colors
            star = new VBO<Vector3>(new Vector3[] {
                //new Vector3(0,-outerradius,0),
                //new Vector3(innerrdius*Sin36,-innerrdius*Cos36, 0),
                //new Vector3(outerradius*Sin72,-outerradius*Cos72,0),
                //new Vector3(innerrdius*Sin72,innerrdius*Cos72+10, 0),
                //new Vector3(outerradius*Sin36,outerradius*Cos36, 0),
                //new Vector3(0,innerrdius, 0),
                //new Vector3(-innerrdius*Sin36,+innerrdius*Cos36, 0),
                //new Vector3(-outerradius*Sin72,+outerradius*Cos72,0),
                //new Vector3(-innerrdius*Sin72,+innerrdius*Cos72, 0),
                //new Vector3(-outerradius*Sin36,-outerradius*Cos36, 0),
                new Vector3(0, 1, 0), new Vector3(-1, -1, 0), new Vector3(1, -1, 0),       
                new Vector3(-1, -1, 0), new Vector3(-3, -2, 0), new Vector3(-1, -3, 0),      
                new Vector3(-1,-3,0), new Vector3(0,-5,0),new Vector3(1,-3,0),
                new Vector3(1,-3,0), new Vector3(3,-2,0), new Vector3(1,-1,0),
                new Vector3(-1,-1,0), new Vector3(1,-1,0), new Vector3(1,-3,0),
                new Vector3(-1,-1,0), new Vector3(-1,-3,0), new Vector3(1,-3,0)
                //внутренность звезды
               

                  //new Vector3(1, -1, 1), new Vector3(-1, -1, 1), new Vector3(-1, -1, -1), new Vector3(1, -1, -1),


                });
            starColor = new VBO<Vector3>(new Vector3[] {
                new Vector3(255, 237, 0), new Vector3(255, 237, 0), new Vector3(255, 237, 0),
                new Vector3(255, 237, 0), new Vector3(255, 237, 0), new Vector3(255, 237, 0),
                new Vector3(255, 237, 0), new Vector3(255, 237, 0), new Vector3(255, 237, 0),
                new Vector3(255, 237, 0), new Vector3(255, 237, 0), new Vector3(255, 237, 0),
                new Vector3(255, 237, 0), new Vector3(255, 237, 0), new Vector3(255, 237, 0),
                new Vector3(255, 237, 0), new Vector3(255, 237, 0), new Vector3(255, 237, 0)});
            starTriangles = new VBO<uint>(new uint[71] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 }, BufferTarget.ElementArrayBuffer);

        
            watch = System.Diagnostics.Stopwatch.StartNew();    //Для точно измерения времени

            Glut.glutMainLoop();
        }

        private static void OnClose()
        {
            // распоряжаться всеми ресурсами, которые были созданы
            star.Dispose();
            starColor.Dispose();
            starTriangles.Dispose();

            program.DisposeChildren = true;     //всё дерево освободить
            program.Dispose();
        }

        private static void OnDisplay()
        {

        }

        private static void OnRenderFrame()
        {
            // подсчитать, сколько времени прошло с момента последнего кадра
            watch.Stop();

            watch.Restart();

            // используем deltaTime, чтобы отрегулировать угол звезды(её вращение)
            angle += deltaTime;

            // настройте окно просмотра OpenGL и очистите биты цвета и глубины
            Gl.Viewport(0, 0, width, height);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // используйте нашу  программу
            Gl.UseProgram(program);

            // привязать позиции вершин, цвета и элементы пирамиды
            program["model_matrix"].SetValue(Matrix4.CreateRotationY(angle) * Matrix4.CreateTranslation(new Vector3(0.5f, 1.5, 0)));    //отображение выше ниже
            Gl.BindBufferToShaderAttribute(star, program, "vertexPosition");
            Gl.BindBufferToShaderAttribute(starColor, program, "vertexColor");
            Gl.BindBuffer(starTriangles);

            // наривать звезду через труегольники
            Gl.DrawElements(BeginMode.Triangles, starTriangles.Count, DrawElementsType.UnsignedInt, IntPtr.Zero);

            // привязать позиции вершин, цвета и элементы 
            program["model_matrix"].SetValue(Matrix4.CreateRotationY(angle / 2) * Matrix4.CreateRotationX(angle) * Matrix4.CreateTranslation(new Vector3(1.5f, 0, 0)));
   


            Glut.glutSwapBuffers();
        }

        public static string VertexShader = @"
#version 130

in vec3 vertexPosition;
in vec3 vertexColor;

out vec3 color;

uniform mat4 projection_matrix;
uniform mat4 view_matrix;
uniform mat4 model_matrix;

void main(void)
{
    color = vertexColor;
    gl_Position = projection_matrix * view_matrix * model_matrix * vec4(vertexPosition, 1);
}
";

        public static string FragmentShader = @"
#version 130

in vec3 color;

out vec4 fragment;

void main(void)
{
    fragment = vec4(color, 1);
}
";
    }
}
