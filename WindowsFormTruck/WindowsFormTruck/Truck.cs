using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsTrucks
{
    public class Truck
    {

        /// <summary> 
        /// Левая координата отрисовки грузовика
        /// </summary> 
        private float _startPosX;
        /// <summary> 
        /// Правая кооридната отрисовки грузовика
        /// </summary> 
        private float _startPosY;
        /// <summary> 
        /// Ширина окна отрисовки 
        /// </summary> 
        private int _pictureWidth;
        //Высота окна отрисовки 
        private int _pictureHeight;
        /// <summary> 
        /// Ширина отрисовки грузовика 
        /// </summary> 
        private const int truckWidth = 100;
        /// <summary> 
        /// Высота отрисовки грузовика 
        /// </summary> 
        private const int truckHeight = 60;
        /// <summary> 
        /// Максимальная скорость 
        /// </summary> 
        public int MaxSpeed { private set; get; }
        /// <summary> 
        /// Вес грузовика
        /// </summary> 
        public float Weight { private set; get; }
        /// <summary> 
        /// Основной цвет 
        /// </summary> 
        public Color MainColor { private set; get; }
        /// <summary> 
        /// Дополнительный цвет 
        /// </summary> 
        public Color DopColor { private set; get; }
        /// <summary> 
        /// Признак наличия лампочки
        /// </summary> 
        public bool Lamp { private set; get; }
        /// <summary> 
        /// Признак наличия тента
        /// </summary> 
        public bool Tilt { private set; get; }
        /// <summary> 
        /// Конструктор 
        /// </summary> 
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param> 
        /// <param name="mainColor">Основной цвет кузова</param> 
        /// <param name="dopColor">Дополнительный цвет</param> 
        /// <param name="Lamp">Признак наличия лампочки</param> 
        /// <param name="Tilt">Признак наличия тента</param> 
        public Truck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool lamp, bool tilt)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Lamp = lamp;
            Tilt = tilt;
        }
        /// <summary> 
        /// Установка позиции грузовика 
        /// </summary> 
        /// <param name="x">Координата X</param> 
        /// <param name="y">Координата Y</param> 
        /// <param name="width">Ширина картинки</param> 
        /// <param name="height">Высота картинки</param> 
        public void SetPosition(int x, int y, int width, int height)
        {
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
                    if (_startPosX + step < _pictureWidth - truckWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево 
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх 
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз 
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - truckHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary> 
        /// Отрисовка грузовика
        /// </summary> 
        /// <param name="g"></param> 
        public void DrawTruck(Graphics g)
        {
            Brush brOrange = new SolidBrush(Color.Orange);
            g.FillRectangle(brOrange, _startPosX + 60, _startPosY + 0, 30, 30);
            g.FillRectangle(brOrange, _startPosX +30 , _startPosY +15, 30, 15);
            g.FillRectangle(brOrange, _startPosX + 60, _startPosY - 10, 30, 10);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 70, _startPosY + 0, 20, 20);
            Brush brBlack = new SolidBrush(Color.Black);
            g.FillEllipse(brBlack, _startPosX+30, _startPosY+ 30, 15,15);
            g.FillEllipse(brBlack, _startPosX + 50, _startPosY + 30, 15, 15);
            g.FillEllipse(brBlack, _startPosX + 75, _startPosY + 30, 15, 15);
            g.FillRectangle(brBlack, _startPosX + 30, _startPosY +5, 30, 10);
            Brush brYellow = new SolidBrush(Color.Yellow);
            g.FillRectangle(brYellow, _startPosX + 85, _startPosY - 15, 5, 5);
            
        }
    }
}
