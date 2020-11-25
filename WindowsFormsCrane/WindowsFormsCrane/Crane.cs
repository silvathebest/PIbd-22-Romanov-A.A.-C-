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
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public Crane(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {

                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                FrontCrane = Convert.ToBoolean(strs[4]);
                Hook = Convert.ToBoolean(strs[5]);
                BackPipe = Convert.ToBoolean(strs[6]);
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес крана</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="FrontCrane">Признак наличия переднего крана</param>
        /// <param name="Hook">Признак наличия боковых ковша</param>
        /// <param name="BackPipe">Признак наличия задней трубы</param>
        public Crane(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontCrane, bool hook, bool backPipe) : base(maxSpeed, weight, mainColor, 120, 50)
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
            Brush dopBrush = new SolidBrush(DopColor);
            //рисуем кузов и гусеницы
            base.DrawTransport(g);
            //кран
            if (FrontCrane)
            {
                g.DrawLine(pen, _startPosX + 30, _startPosY + vehicleHeight - 20, _startPosX + 70, _startPosY - 15);
                g.DrawLine(pen, _startPosX + 70, _startPosY - 15, _startPosX + 80, _startPosY + 10);
            }
            //крюк
            if (Hook)
            {
                g.DrawArc(pen, _startPosX + 75, _startPosY + 10, 10, 10, 90, 180);
            }
            //задняя труба
            if (BackPipe)
            {
                g.FillRectangle(dopBrush, _startPosX + 15, _startPosY + vehicleHeight - 40, 10, 25);
            }
        }

        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString() => $"{base.ToString()}{separator}{DopColor.Name}" +
            $"{separator}{FrontCrane}{separator}{BackPipe}{ separator}{ Hook}";

    }
}
