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
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelParking parking;
        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;
        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBox1.Items.Add("Уровень " + (i + 1));
            }
            listBox1.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBox1.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать грузовик "
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetAotutruck_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var car = new Aotutruck(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        int place = parking[listBox1.SelectedIndex] + car;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }
       
       
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                if (maskedTextBoxTake.Text != "")
                {
                    var car = parking[listBox1.SelectedIndex] - Convert.ToInt32(maskedTextBoxTake.Text);
                    if (car != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                        pictureBoxTake.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.SetPosition(5, 25, pictureBoxTake.Width, pictureBoxTake.Height);
                        car.DrawCar(gr);
                        pictureBoxTake.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                        pictureBoxTake.Image = bmp;
                    }
                    Draw();
                }
            }
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать грузовик полуприцеп"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTruck_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var car = new Truck(100, 1000, dialog.Color);
                    int place = parking[listBox1.SelectedIndex] + car;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }
    }
}
