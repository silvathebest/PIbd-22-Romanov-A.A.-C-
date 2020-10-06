using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    public class Crane : TrackedVehicle
    {
        // Дополнительный цвет
        public Color DopColor { private set; get; }
        // Признак наличия крана
        public bool FrontCrane { private set; get; }
        // Признак наличия крюка
        public bool Hook { private set; get; }
        // Признак наличия задней трубы
        public bool BackPipe { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="FrontCrane">Признак наличия переднего спойлера</param>
        /// <param name="Hook">Признак наличия боковых спойлеров</param>
        /// <param name="BackPipe">Признак наличия заднего спойлера</param>
        public Crane(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontCrane, bool hook, bool backPipe) : base(maxSpeed, weight, mainColor, 120, 200)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontCrane = frontCrane;
            Hook = hook;
            BackPipe = backPipe;
        }

        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(MainColor);
            Brush dopBrush = new SolidBrush(DopColor);
            //рисуем кузов и гусеницы
            base.DrawTransport(g);
            //кран
            if (FrontCrane)
            {
                g.DrawLine(pen, _startPosX + 30, _startPosY + vehicleHeight - 50, _startPosX + 70, _startPosY + 30);
                g.DrawLine(pen, _startPosX + 70, _startPosY + 30, _startPosX + 80, _startPosY + 70);
            }
            //крюк
            if (Hook)
            {
                g.DrawArc(pen, _startPosX + 65, _startPosY + 70, 30, 30, 90, 180);
            }
            //задняя труба
            if (BackPipe)
            {
                g.FillRectangle(dopBrush, _startPosX + 15, _startPosY + vehicleHeight - 70, 10, 20);
            }
        }
    }
}
