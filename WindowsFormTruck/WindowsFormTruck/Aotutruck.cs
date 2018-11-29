﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormTruck;

namespace WindowsFormsTrucks
{
    public class Aotutruck : Truck 
    {
        private const int truckWidth = 100;
        
        private const int truckHeight = 60;
        
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
        public Aotutruck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool lamp , bool tilt) :
 base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Lamp = lamp;
            Tilt = tilt;
           
        }
        public override void DrawCar(Graphics g)
        {
            Brush brOrange = new SolidBrush(MainColor);
            g.FillRectangle(brOrange, _startPosX + 60, _startPosY + 0, 30, 30);
            g.FillRectangle(brOrange, _startPosX +30 , _startPosY +15, 30, 15);
            g.FillRectangle(brOrange, _startPosX + 60, _startPosY - 10, 30, 10);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 70, _startPosY + 0, 20, 20);
            Brush brBlack = new SolidBrush(Color.Black);
            g.FillEllipse(brBlack, _startPosX+30, _startPosY+ 30, 15,15);
            g.FillEllipse(brBlack, _startPosX + 50, _startPosY + 30, 15, 15);
            g.FillEllipse(brBlack, _startPosX + 75, _startPosY + 30, 15, 15);
            if (Tilt)
            {
                Brush brDopColor= new SolidBrush(DopColor);
                g.FillRectangle(brDopColor, _startPosX + 30, _startPosY + 5, 30, 10);
            }
            if (Lamp)
            {
                Brush brYellow = new SolidBrush(Color.Yellow);
                g.FillRectangle(brYellow, _startPosX + 85, _startPosY - 12, 5, 5);
            }
            
        }
    }
}
