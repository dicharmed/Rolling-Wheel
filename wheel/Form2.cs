using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using System.Windows.Forms;

namespace wheel
{
    public partial class Form2 : Form
    {
        const double Pi = 3.14;
        //коодинаты точки А
        float Xa, Ya;       
        //коодинаты центра колеса
        float Xo, Yo;
        float XBase, YBase;
        float X, Y;
        double Fi, DeltaFi;
        double Lambda, LambdaA, DeltaLambda;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DeltaLambda = 0.25;
            XBase = (float)(4 * Pi);
            YBase = XBase / Axis1.Width * Axis1.Height;
        }

        private void CommandInit_Click(object sender, EventArgs e) //Кнопка "Данные"
        {
            CommandStart.Enabled = true;
            //DeltaFi = Convert.ToDouble(TextDeltaFi.Text);
            DeltaFi = double.Parse(TextDeltaFi.Text, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
            LambdaA = double.Parse(TextLambdaA.Text, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);

            InitAxis();//Определяет вид систем координат д/отображения катящегося колеса(Аксис1) и траекторий точек радиуса колеса(Аксис2)

            //точка A
            Xa = (float)(-4 * Pi);
            Ya = (float)(1 - LambdaA);

            //Колесо
            Xo = (float)(-4 * Pi);
            Yo = 1;
            Axis1.StatToDin();//
            Axis1.Pix_type = 3;
            Axis1.Pix_Size = 2 / XBase;
            Axis1.PixDraw(Xo, Yo, Color.Red, 2);//

            //радиус
            Axis1.Pix_color = Color.Blue;
            Axis1.Line(Xa, Ya, Xo, Yo, 2);//
            Axis1.DinToPic();//     
        }
                                    //Определяет вид систем координат д/отображения 
        private void InitAxis()    //катящегося колеса(Аксис1) и траекторий точек радиуса колеса(Аксис2)
        {
            //Колесо
            Axis1.Axis_Type = 1;
            Axis1.Pix_type = 3;
            Axis1.Pix_Size = 2 / XBase;
            Axis1.x_Base = XBase;
            Axis1.y_Base = YBase;
            Axis1.AxisDraw(); //рисуем координатную ось 1

            //Траектории
            Axis2.Axis_Type = 1;
            Axis2.x_Base = XBase;
            Axis2.y_Base = YBase;
            Axis2.Pix_Size = 0;
            Axis2.AxisDraw(); //рисуем координатную ось 2
        }

        private void CommandStop_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;//отключает таймер, что обеспечивает остановку колеса
        }

        private void CommandStart_Click(object sender, EventArgs e)
        {
            Fi = -4 * Pi;
            Timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Lambda = 0;

          
            while (Lambda < LambdaA)
            {
                X = (float)(Fi - Lambda * Sin(Fi));
                Y = (float)(1 - Lambda * Cos(Fi));
                Axis2.PixDraw(X, Y, Color.Black, 0);
                Lambda = Lambda + DeltaLambda;

            };

            Xo = (float)Fi;
            Yo = 1;

            //новые координаты точки А
            Xa = (float)(Fi - LambdaA * Sin(Fi));
            Ya = (float)(1 - LambdaA * Cos(Fi));

            //рисуем точку траектории в статический буфер
            Axis1.Pix_type = 1;
            Axis1.Pix_Size = (float)(0.01 * (YBase / XBase));
            Axis1.PixDraw(Xa, Ya, Color.Red, 1);

            //рисуем колесо в динамический буфер
            Axis1.Pix_type = 3;
            Axis1.Pix_Size = 2 / XBase;
            Axis1.PixDraw(Xo, Yo, Color.Red, 2);

            //рисуем радиус в динамический буфер
            Axis1.Pix_color = Color.Blue;
            Axis1.Line(Xa, Ya, Xo, Yo, 2);

            //отображаем общую картинку
            Axis1.DinToPic();
            Fi = Fi + DeltaFi;
        }                    
     
        private void Form2_Resize(object sender, EventArgs e)
        {
            Axis1.Width = this.DisplayRectangle.Width - GroupBox1.Width;
            Axis2.Width = Axis1.Width;
            Axis1.Top = 0;
            Axis1.Left = 0;
            Axis2.Left = 0;
            Axis1.Height = this.DisplayRectangle.Height / 2;
            Axis2.Height = this.DisplayRectangle.Height / 2;
            Axis2.Top = Axis1.Height;
            YBase = XBase / Axis1.Width * Axis1.Height;
            GroupBox1.Left = Axis1.Width;
        }

    }
}
