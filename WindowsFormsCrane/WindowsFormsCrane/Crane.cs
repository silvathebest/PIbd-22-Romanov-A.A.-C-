using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    class Crane
    {
        // Левая координата отрисовки крана
        private float _startPosX;
        /// Правая кооридната отрисовки крана
        private float _startPosY;

        // Ширина окна отрисовки
        private int _pictureWidth;
        // Высота окна отрисовки
        private int _pictureHeight;

        // Ширина отрисовки гусеничной машины
        private readonly int vehicleWidth = 120;
        // Высота отрисовки гусеничной машины
        private readonly int vehicleHeight = 200;

        // Максимальная скорость
        public int MaxSpeed { private set; get; }
        // Вес гусеничной машины
        public float Weight { private set; get; }
        // Основной цвет кузова
        public Color MainColor { private set; get; }
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
       bool frontCrane, bool hook, bool backPipe)
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
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(MainColor);
            Brush dopBrush = new SolidBrush(DopColor);
            //рисуем кузов гуснечной машины
            g.FillRectangle(brush, _startPosX + 10, _startPosY + vehicleHeight - 50, vehicleWidth - 20, 30);
            //гусеницы
            g.FillEllipse(dopBrush, _startPosX, _startPosY + vehicleHeight - 20, 25, 20);
            g.FillEllipse(dopBrush, _startPosX + 30, _startPosY + vehicleHeight - 20, 25, 20);
            g.FillEllipse(dopBrush, _startPosX + 55, _startPosY + vehicleHeight - 20, 25, 20);
            g.FillEllipse(dopBrush, _startPosX + 80, _startPosY + vehicleHeight - 20, 25, 20);
            g.FillEllipse(dopBrush, _startPosX + 105, _startPosY + vehicleHeight - 20, 25, 20);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + vehicleHeight - 20, vehicleWidth - 10, 20);
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
