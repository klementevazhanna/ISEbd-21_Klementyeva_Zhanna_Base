using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars1
{

    public class SportCar
    {

        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        public float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        public float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        public int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        public int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private readonly int carWidth = 150;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        public readonly int carHeight = 50;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool Motor { private set; get; }
        /// <summary>
        /// Признак наличия моторов
        /// </summary>
        public bool Square { private set; get; }

        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес катера</param>
        /// <param name="mainColor">Основной цвет катера</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="motor">Признак наличия моторов</param>
        /// <param name="square">Признак наличия внутренности катера </param>


        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool motor, bool square)

        /* public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool motor, bool square)
        */
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Motor = motor;
            Square = square;

        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            // Продумать логику
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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

        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            //сам катер
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, _startPosX + 30, _startPosY, _startPosX + 120, _startPosY);
            g.DrawLine(pen, _startPosX + 30, _startPosY + 40, _startPosX + 120, _startPosY + 40);
            g.DrawLine(pen, _startPosX + 120, _startPosY, _startPosX + 160, _startPosY + 20);
            g.DrawLine(pen, _startPosX + 120, _startPosY + 40, _startPosX + 160, _startPosY + 20);
            //задняя часть
            g.DrawLine(pen, _startPosX + 30, _startPosY, _startPosX + 40, _startPosY + 20);
            g.DrawLine(pen, _startPosX + 30, _startPosY + 40, _startPosX + 40, _startPosY + 20);
            if (Motor)
            {
                pen = new Pen(Color.Red);
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
