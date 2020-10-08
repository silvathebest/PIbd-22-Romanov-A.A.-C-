using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCrane
{
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Parking<TrackedVehicle> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<TrackedVehicle>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гусеничную машину"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTrackedVehicle_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var vehicle = new TrackedVehicle(100, 1000, dialog.Color);
                if (parking + vehicle)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }

        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать кран"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetCrane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var crane = new Crane(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, true);
                    if (parking + crane)
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
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeVehicle_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPickPlace.Text != "")
            {
                var vehicle = parking - Convert.ToInt32(maskedTextBoxPickPlace.Text);
                if (vehicle != null)
                {
                    CraneForm form = new CraneForm();
                    form.SetVehicle(vehicle);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
