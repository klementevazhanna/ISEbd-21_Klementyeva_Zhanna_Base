using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCars1
{
    public class BaseBoat : AbstrBoat
    {
        private readonly int carWidth = 150;
        private readonly int carHeight = 50;
        protected readonly char separator = ';';

        public BaseBoat(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public BaseBoat(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step >= 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step >= 0)
                    {
                        _startPosY -= step;
                    }
                    break;

                //вниз
                case Direction.Down:
                    if (_startPosY + step <= _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            //сам катер
            Pen pen = new Pen(MainColor);
            g.DrawLine(pen, _startPosX + 30, _startPosY, _startPosX + 120, _startPosY);
            g.DrawLine(pen, _startPosX + 30, _startPosY + 40, _startPosX + 120, _startPosY + 40);
            g.DrawLine(pen, _startPosX + 120, _startPosY, _startPosX + 160, _startPosY + 20);
            g.DrawLine(pen, _startPosX + 120, _startPosY + 40, _startPosX + 160, _startPosY + 20);
            //задняя часть
            g.DrawLine(pen, _startPosX + 30, _startPosY, _startPosX + 40, _startPosY + 20);
            g.DrawLine(pen, _startPosX + 30, _startPosY + 40, _startPosX + 40, _startPosY + 20);
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}
