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
    public partial class CraneForm : Form
    {
        private ITransport vehicle;
        public CraneForm()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bitmap = new Bitmap(pictureBoxCrane.Width, pictureBoxCrane.Height);
            Graphics gr = Graphics.FromImage(bitmap);
            vehicle.DrawTransport(gr);
            pictureBoxCrane.Image = bitmap;
        }

        private void buttonCreateTrackedVehicle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            vehicle = new TrackedVehicle(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            vehicle.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCrane.Width,
           pictureBoxCrane.Height);
            Draw();

        }

        private void buttonCreateCrane_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            vehicle = new Crane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Black, true, true, true);
            vehicle.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCrane.Width,
           pictureBoxCrane.Height);
            Draw();

        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    vehicle.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    vehicle.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    vehicle.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    vehicle.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
