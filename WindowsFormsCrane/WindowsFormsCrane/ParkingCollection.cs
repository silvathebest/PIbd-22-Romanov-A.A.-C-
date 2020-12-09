using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    class ParkingCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public void DelParkingNumber(int index)
        {
            if (index > -1 && index < parkingStages.Count)
            {
                parkingStages.Remove(Keys[index]);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<Vehicle> this[string ind] => parkingStages.ContainsKey(ind) ? parkingStages[ind] : null;

        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {

            using (StreamWriter streamWriter = new StreamWriter
            (filename, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine("ParkingCollection");
                foreach (var level in parkingStages)
                {
                    streamWriter.WriteLine("Parking" + separator + level.Key);

                    ITransport vehicle;
                    for (int i = 0; (vehicle = level.Value.GetNext(i)) != null; i++)
                    {
                        if (vehicle.GetType().Name == "Crane")
                        {
                            streamWriter.Write("Crane" + separator);
                        }
                        else if (vehicle.GetType().Name == "TrackedVehicle")
                        {
                            streamWriter.Write("TrackedVehicle" + separator);
                        }
                        streamWriter.WriteLine(vehicle);
                    }
                }
            }
        }

        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            using (StreamReader streamReader = new StreamReader
            (filename, System.Text.Encoding.Default))
            {
                if (streamReader.ReadLine().Contains("ParkingCollection"))
                {
                    parkingStages.Clear();
                }
                else
                {
                    throw new FormatException("Неверный формат файла");
                }
                Vehicle transport = null;
                string key = string.Empty;
                string line;
                for (int i = 0; (line = streamReader.ReadLine()) != null; i++)
                {
                    if (line.Contains("Parking"))
                    {
                        key = line.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                    }
                    else if (line.Contains(separator))
                    {
                        if (line.Contains("Crane"))
                        {
                            transport = new Crane(line.Split(separator)[1]);
                        }
                        else if (line.Contains("TrackedVehicle"))
                        {
                            transport = new TrackedVehicle(line.Split(separator)[1]);
                        }
                        if (!(parkingStages[key] + transport))
                        {
                            throw new TypeLoadException("Не удалось загрузить автомобиль на парковку");
                        }
                    }
                }
            }
        }
    }
}
