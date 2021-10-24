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
    public partial class GavanForm : Form
    {
        public GavanForm()
        {
            InitializeComponent();
            parking = new Parking<BaseBoat>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private readonly Parking<BaseBoat> parking;

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        
        private void btnTake_Click(object sender, EventArgs e)
        {
            if (mTBLot.Text != "")
            {
                var ab = Convert.ToInt32(mTBLot.Text) - 1;
                var car = parking - Convert.ToInt32(ab);
                if (car != null)
                {
                    FormCar form = new FormCar();
                    form.setBoat(car);
                    form.ShowDialog();
                }
                mTBLot.Text = "";
                Draw();
            }
        }

        private void btnParkCater_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new Cater(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if ((parking + car) > -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void btnParkBoat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new BaseBoat(100, 1000, dialog.Color);
                if ((parking + car) > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
    }
}
