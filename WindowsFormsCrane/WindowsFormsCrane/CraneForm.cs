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
        public void SetVehicle(ITransport vehicle)
        {
            this.vehicle = vehicle;
            Draw();
        }

        private void Draw()
        {
            Bitmap bitmap = new Bitmap(pictureBoxCrane.Width, pictureBoxCrane.Height);
            Graphics gr = Graphics.FromImage(bitmap);
            vehicle.DrawTransport(gr);
            pictureBoxCrane.Image = bitmap;
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
