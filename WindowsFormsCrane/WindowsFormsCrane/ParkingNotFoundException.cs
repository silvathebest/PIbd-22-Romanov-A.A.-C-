using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    public class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i) : base("Не найден автомобиль по месту " + i)
        { }
    }

}
