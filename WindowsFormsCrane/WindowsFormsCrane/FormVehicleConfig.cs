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
    public partial class FormVehicleConfig : Form
    {
        Vehicle vehicle = null;

        public Action<Vehicle> eventAddVehicle;
        public FormVehicleConfig()
        {
            InitializeComponent();

            panelBlack.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawVehicle()
        {
            if (vehicle != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxVehicle.Width, pictureBoxVehicle.Height);
                Graphics gr = Graphics.FromImage(bmp);
                vehicle.SetPosition(5, 15, pictureBoxVehicle.Width, pictureBoxVehicle.Height);
                vehicle.DrawTransport(gr);
                pictureBoxVehicle.Image = bmp;
            }
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddVehicle == null)
            {
                eventAddVehicle = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddVehicle += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelTrackedVehicle_MouseDown(object sender, MouseEventArgs e)
        {
            var trackedVehicle = new TrackedVehicle((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value,
                Color.White);
            labelTrackedVehicle.DoDragDrop(trackedVehicle, DragDropEffects.Move |
           DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelCrane_MouseDown(object sender, MouseEventArgs e)
        {
            var crane = new Crane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value,
                Color.White, Color.Black, checkBoxCrane.Checked, checkBoxHook.Checked, checkBoxPipe.Checked);
            labelCrane.DoDragDrop(crane, DragDropEffects.Move |
           DragDropEffects.Copy);
        }

        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelVehicle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TrackedVehicle)) || e.Data.GetDataPresent(typeof(Crane)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }


        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelVehicle_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TrackedVehicle)))
            {
                vehicle = (Vehicle)e.Data.GetData(typeof(TrackedVehicle));
            }
            else if (e.Data.GetDataPresent(typeof(Crane)))
            {
                vehicle = (Vehicle)e.Data.GetData(typeof(Crane));
            }

            DrawVehicle();
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (vehicle != null)
            {
                vehicle.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawVehicle();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (vehicle != null)
            {
                if (vehicle is Crane)
                {
                    (vehicle as Crane).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawVehicle();
                }
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddVehicle?.Invoke(vehicle);
            Close();
        }

    }
}
