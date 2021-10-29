using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCars1
{
    public partial class FormCar : Form
    {
        private ITransport car;

        public FormCar()
        {
            InitializeComponent();
        }

        public void setBoat(ITransport car)
        {
            this.car = car;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car?.DrawTransport(gr);
            pictureBox1.Image = bmp;
        }

        private void btnСreateBoat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new BaseBoat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black);            
            car.SetPosition(rnd.Next(20, 100), rnd.Next(50, 200), pictureBox1.Width, pictureBox1.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp1":
                    car?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown1":
                    car?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft1":
                    car?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight1":
                    car?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void btnCreateCater_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new Cater(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Red, true, true);
            car.SetPosition(rnd.Next(20, 100), rnd.Next(50, 200), pictureBox1.Width, pictureBox1.Height);
            Draw();
        }
    }
} 
