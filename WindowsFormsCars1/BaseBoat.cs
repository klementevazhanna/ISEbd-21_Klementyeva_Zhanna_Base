using System;
using System.Drawing;

namespace WindowsFormsCars1
{
    public class BaseBoat : AbstrBoat, IEquatable<BaseBoat>
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

        public bool Equals(BaseBoat other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(!(obj is BaseBoat))
            {
                return false;
            }
            else 
            {
                return Equals(obj as BaseBoat);
            }
        }
    }
}
