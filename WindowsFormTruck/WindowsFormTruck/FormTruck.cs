using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsTrucks;

namespace WindowsFormTruck
{
    public partial class FormTruck : Form
    {
        private ITransport truck;
        public FormTruck()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTrucks.Width, pictureBoxTrucks.Height);
            Graphics gr = Graphics.FromImage(bmp);
            truck.DrawCar(gr);
            pictureBoxTrucks.Image = bmp;
        }
       
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки 
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    truck.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    truck.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    truck.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    truck.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        private void buttonCreateAutotruck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            truck = new Aotutruck(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true);
            truck.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTrucks.Width, pictureBoxTrucks.Height);
            Draw();
        }
        private void buttonCreateTruck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            truck = new Truck(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            truck.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTrucks.Width, pictureBoxTrucks.Height);
            Draw();
        }
    }
}
