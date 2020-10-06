using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    public class TrackedVehicle : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected readonly int vehicleWidth = 90;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        protected readonly int vehicleHeight = 50;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public TrackedVehicle(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки автомобиля</param>
        /// <param name="carHeight">Высота отрисовки автомобиля</param>
        protected TrackedVehicle(int maxSpeed, float weight, Color mainColor, int carWidth, int
       carHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.vehicleWidth = carWidth;
            this.vehicleHeight = carHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - vehicleWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - vehicleHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(MainColor);
            Brush brushBlack = new SolidBrush(Color.Black);
            //рисуем кузов гуснечной машины
            g.FillRectangle(brush, _startPosX + 10, _startPosY + vehicleHeight - 50, vehicleWidth - 20, 30);
            //гусеницы
            g.FillEllipse(brushBlack, _startPosX, _startPosY + vehicleHeight - 20, 25, 20);
            g.FillEllipse(brushBlack, _startPosX + 30, _startPosY + vehicleHeight - 20, 25, 20);
            g.FillEllipse(brushBlack, _startPosX + 55, _startPosY + vehicleHeight - 20, 25, 20);
            g.FillEllipse(brushBlack, _startPosX + 80, _startPosY + vehicleHeight - 20, 25, 20);
            g.FillEllipse(brushBlack, _startPosX + 105, _startPosY + vehicleHeight - 20, 25, 20);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + vehicleHeight - 20, vehicleWidth - 10, 20);
        }
    }
}
