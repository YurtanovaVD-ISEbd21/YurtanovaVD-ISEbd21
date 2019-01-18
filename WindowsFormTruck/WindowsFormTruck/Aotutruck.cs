using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormTruck;


namespace WindowsFormsTrucks
{
    public class Aotutruck : Truck , IComparable<Aotutruck>, IEquatable<Aotutruck>
    {
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
        public Aotutruck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool lamp , bool tilt) :
 base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Lamp = lamp;
            Tilt = tilt;
           
        }
        public Aotutruck(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Lamp = Convert.ToBoolean(strs[4]);
                Tilt = Convert.ToBoolean(strs[5]);
            }
        }
        public override void DrawCar(Graphics g)
        {
            Brush brOrange = new SolidBrush(MainColor);
            g.FillRectangle(brOrange, _startPosX + 60, _startPosY + 0, 30, 30);
            g.FillRectangle(brOrange, _startPosX + 30, _startPosY + 15, 30, 15);
            g.FillRectangle(brOrange, _startPosX + 60, _startPosY - 10, 30, 10);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 70, _startPosY + 0, 20, 20);
            Brush brBlack = new SolidBrush(Color.Black);
            g.FillEllipse(brBlack, _startPosX + 30, _startPosY + 30, 15, 15);
            g.FillEllipse(brBlack, _startPosX + 50, _startPosY + 30, 15, 15);
            g.FillEllipse(brBlack, _startPosX + 75, _startPosY + 30, 15, 15);
            if (Tilt)
            {
                Brush brDopColor = new SolidBrush(DopColor);
                g.FillRectangle(brDopColor, _startPosX + 30, _startPosY + 5, 30, 10);
            }
            if (Lamp)
            {
                Brush brYellow = new SolidBrush(Color.Yellow);
                g.FillRectangle(brYellow, _startPosX + 85, _startPosY - 12, 5, 5);
            }
        }
            /// Смена дополнительного цвета
            /// </summary>
            /// <param name="color"></param>
            /// 
            public void SetDopColor(Color color)
            {
                DopColor = color;
            }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Lamp + ";" + Tilt + ";";
        }
        /// <summary>
        /// Метод интерфейса IComparable для класса Aotutruck
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Aotutruck other)
        {
            var res = (this is Truck).CompareTo(other is Truck);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
           
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса Aotutruck
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Aotutruck other)
        {
            var res = (this as Truck).Equals(other as Truck);
            if (!res)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            return true;

        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Aotutruck carObj = obj as Aotutruck;
            if (carObj == null)
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

