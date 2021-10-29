using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCars1
{
    class Cater : BaseBoat
    {
        public Color DopColor { private set; get; }

        public bool Motor { private set; get; }

        public bool Square { private set; get; }

        public Cater(int maxSpeed, float weight, Color mainColor, Color dopColor, bool motor, bool square)
            : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Motor = motor;
            Square = square;
        }

        public void setDopColor(Color dopColor)
        {
            DopColor = dopColor;
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            Pen pen = new Pen(DopColor);
            if (Motor)
            {
                //моторчики
                g.DrawEllipse(pen, _startPosX + 15, _startPosY + 5, 20, 10);
                g.DrawEllipse(pen, _startPosX + 15, _startPosY + 25, 20, 10);
                g.DrawEllipse(pen, _startPosX + 20, _startPosY + 15, 20, 10);
                g.DrawLine(pen, _startPosX + 25, _startPosY + 5, _startPosX + 25, _startPosY + 15);
                g.DrawLine(pen, _startPosX + 25, _startPosY + 25, _startPosX + 25, _startPosY + 35);
                g.DrawLine(pen, _startPosX + 30, _startPosY + 15, _startPosX + 30, _startPosY + 25);
            }
            if (Square)
            {
                //внутренность катера
                g.DrawRectangle(pen, _startPosX + 45, _startPosY + 10, 5, 20);
                g.DrawRectangle(pen, _startPosX + 55, _startPosY + 10, 15, 20);
                g.DrawRectangle(pen, _startPosX + 55, _startPosY + 10, 50, 20);
            }
        }


    }
}
