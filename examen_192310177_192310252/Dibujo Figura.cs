using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace examen_192310177_192310252
{
    class Dibujo_Figura
    {
        int x, y, alto, ancho;
        int mitadAncho, mitadAlto;

        public void DibujarF(ref Graphics papel, int Alto, int Ancho)
        {
            alto = Alto; // 479
            ancho = Ancho;// 592


            mitadAncho = ancho / 2;
            mitadAlto = alto / 2;


            Pen Lapiz = new Pen(Color.Gray);

            //lineas de atras
            for (int i = 0; i < 20; i++)
            {
                papel.DrawLine(Lapiz, 0, 10 + (15 * i), ancho, 10 + (15 * i));
            }

            //papel.DrawLine(Lapiz,mitadAncho,0,mitadAncho,alto);
            //papel.DrawLine(Lapiz,0, mitadAlto, ancho, mitadAlto);

            //Pelo
            SolidBrush brocha3 = new SolidBrush(Color.Gray);
            papel.FillRectangle(brocha3, mitadAncho - 46, mitadAlto - 180, 90, 20);

            //Cara
            SolidBrush brocha = new SolidBrush(Color.Green);
            papel.FillRectangle(brocha, mitadAncho - 46, mitadAlto - 160, 90, 80);

            //Ojos
            SolidBrush brocha4 = new SolidBrush(Color.White);
            papel.FillEllipse(brocha4, mitadAncho - 30, mitadAlto - 150, 20, 30);
            papel.FillEllipse(brocha4, mitadAncho + 10, mitadAlto - 150, 20, 30);
            SolidBrush brocha5 = new SolidBrush(Color.Black);
            papel.FillEllipse(brocha5, mitadAncho - 30, mitadAlto - 130, 20, 10);
            papel.FillEllipse(brocha5, mitadAncho + 10, mitadAlto - 130, 20, 10);

            //cejas
            papel.FillRectangle(brocha5, mitadAncho + 10, mitadAlto - 155, 20, 5);
            papel.FillRectangle(brocha5, mitadAncho - 30, mitadAlto - 155, 20, 5);

            //Boca
            Pen lapiz2 = new Pen(Color.Black, 2);
            papel.FillRectangle(brocha4, mitadAncho - 30, mitadAlto - 110, 60, 10);
            papel.DrawRectangle(lapiz2, mitadAncho - 30, mitadAlto - 110, 60, 10);

            //Nariz
            Pen lapiz3 = new Pen(Color.Black);
            papel.DrawRectangle(lapiz3, mitadAncho - 2, mitadAlto - 135, 5, 20);
            papel.DrawRectangle(lapiz3, mitadAncho + 3, mitadAlto - 121, 5, 6);
            papel.DrawRectangle(lapiz3, mitadAncho - 7, mitadAlto - 121, 5, 6);
            papel.DrawRectangle(lapiz2, mitadAncho, mitadAlto - 110, 20, 10);
            papel.DrawRectangle(lapiz2, mitadAncho - 20, mitadAlto - 110, 20, 10);

            //cuerpo 
            SolidBrush brocha1 = new SolidBrush(Color.Brown);
            papel.FillRectangle(brocha1, mitadAncho - 60, mitadAlto - 80, 120, 150);
            papel.DrawRectangle(lapiz2, mitadAncho - 60, mitadAlto - 80, 120, 150);
            papel.DrawEllipse(lapiz2, mitadAncho - 30, mitadAlto - 150, 20, 30);
            papel.DrawEllipse(lapiz2, mitadAncho + 10, mitadAlto - 150, 20, 30);
            papel.DrawRectangle(lapiz2, mitadAncho - 46, mitadAlto - 160, 90, 80);
            papel.DrawRectangle(lapiz2, mitadAncho - 46, mitadAlto - 180, 90, 20);
            //Brazos
            Pen lapiz1 = new Pen(Color.Black);
            Point[] brazo1 = new Point[]
            {
                new Point(mitadAncho-60,mitadAlto-40),
                new Point(mitadAncho-60,mitadAlto),
                new Point(mitadAncho-85,mitadAlto+30),
                new Point(mitadAncho-100,mitadAlto+30),
                new Point(mitadAncho-135,mitadAlto-20),
                new Point(mitadAncho-110,mitadAlto-20),
                new Point(mitadAncho-93,mitadAlto)
            };
            papel.FillPolygon(brocha1, brazo1);
            papel.DrawPolygon(lapiz2, brazo1);
            Point[] brazo2 = new Point[]
           {
                 new Point(mitadAncho+60,mitadAlto-40),
                new Point(mitadAncho+60,mitadAlto),
                new Point(mitadAncho+85,mitadAlto+30),
                new Point(mitadAncho+100,mitadAlto+30),
                new Point(mitadAncho+135,mitadAlto-20),
                new Point(mitadAncho+110,mitadAlto-20),
                new Point(mitadAncho+93,mitadAlto),

           };
            papel.FillPolygon(brocha1, brazo2);
            papel.DrawPolygon(lapiz2, brazo2);

            //Manos
            Point[] mano1 = new Point[]
           {

               new Point(mitadAncho-135,mitadAlto-20),
              new Point(mitadAncho-110,mitadAlto-20),
              new Point(mitadAncho-110,mitadAlto-40),
              new Point(mitadAncho-110,mitadAlto-50),
              new Point(mitadAncho-115,mitadAlto-50),
              new Point(mitadAncho-115,mitadAlto-40),
              new Point(mitadAncho-115,mitadAlto-65),
              new Point(mitadAncho-120,mitadAlto-65),
              new Point(mitadAncho-120,mitadAlto-50),
              new Point(mitadAncho-120,mitadAlto-65),
              new Point(mitadAncho-125,mitadAlto-65),
              new Point(mitadAncho-125,mitadAlto-50),
              new Point(mitadAncho-125,mitadAlto-65),
              new Point(mitadAncho-130,mitadAlto-65),
              new Point(mitadAncho-130,mitadAlto-50),
              new Point(mitadAncho-130,mitadAlto-65),
              new Point(mitadAncho-135,mitadAlto-65),
              new Point(mitadAncho-135,mitadAlto-65),


           };
            papel.FillPolygon(brocha, mano1);
            papel.DrawPolygon(lapiz1, mano1);

            Point[] mano2 = new Point[]
          {

               new Point(mitadAncho+135,mitadAlto-20),
              new Point(mitadAncho+110,mitadAlto-20),
              new Point(mitadAncho+110,mitadAlto-40),
              new Point(mitadAncho+110,mitadAlto-50),
              new Point(mitadAncho+115,mitadAlto-50),
              new Point(mitadAncho+115,mitadAlto-40),
              new Point(mitadAncho+115,mitadAlto-65),
              new Point(mitadAncho+120,mitadAlto-65),
              new Point(mitadAncho+120,mitadAlto-50),
              new Point(mitadAncho+120,mitadAlto-65),
              new Point(mitadAncho+125,mitadAlto-65),
              new Point(mitadAncho+125,mitadAlto-50),
              new Point(mitadAncho+125,mitadAlto-65),
              new Point(mitadAncho+130,mitadAlto-65),
              new Point(mitadAncho+130,mitadAlto-50),
              new Point(mitadAncho+130,mitadAlto-65),
              new Point(mitadAncho+135,mitadAlto-65),
              new Point(mitadAncho+135,mitadAlto-65),


          };
            papel.FillPolygon(brocha, mano2);
            papel.DrawPolygon(lapiz1, mano2);
            //Cuello camisa

            //Pies
            SolidBrush brocha2 = new SolidBrush(Color.Blue);
            papel.FillRectangle(brocha2, mitadAncho - 60, mitadAlto + 70, 120, 40);
            papel.FillRectangle(brocha2, mitadAncho - 50, mitadAlto + 110, 40, 70);
            papel.FillRectangle(brocha2, mitadAncho + 10, mitadAlto + 110, 40, 70);

            papel.DrawRectangle(lapiz2, mitadAncho - 60, mitadAlto + 70, 120, 40);
            papel.DrawRectangle(lapiz2, mitadAncho - 50, mitadAlto + 110, 40, 70);
            papel.DrawRectangle(lapiz2, mitadAncho + 10, mitadAlto + 110, 40, 70);

            //Zapatos
            papel.FillRectangle(brocha1, mitadAncho - 60, mitadAlto + 180, 59, 30);
            papel.FillRectangle(brocha1, mitadAncho + 1, mitadAlto + 180, 59, 30);

            papel.DrawRectangle(lapiz2, mitadAncho - 60, mitadAlto + 180, 59, 30);
            papel.DrawRectangle(lapiz2, mitadAncho + 1, mitadAlto + 180, 59, 30);


















        }
















        }
    }
