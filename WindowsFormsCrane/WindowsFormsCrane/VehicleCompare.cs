using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrane
{
    class VehicleCompare : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Crane && y is Crane)
            {
                return ComparerCrane((Crane)x, (Crane)y);
            }
            if (x is Crane && y is TrackedVehicle)
            {
                return 1;
            }
            if (x is TrackedVehicle && y is Crane)
            {
                return -1;
            }            
            if (x is TrackedVehicle && y is TrackedVehicle)
            {
                return ComparerTrackedVehicle((TrackedVehicle)x, (TrackedVehicle)y);
            }
            return 0;
        }
        private int ComparerTrackedVehicle(TrackedVehicle x, TrackedVehicle y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerCrane(Crane x, Crane y)
        {
            int res = ComparerTrackedVehicle(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.FrontCrane != y.FrontCrane)
            {
                return x.FrontCrane.CompareTo(y.FrontCrane);
            }
            if (x.BackPipe != y.BackPipe)
            {
                return x.BackPipe.CompareTo(y.BackPipe);
            }
            if (x.Hook != y.Hook)
            {
                return x.Hook.CompareTo(y.Hook);
            }
            return 0;
        }
    }
}
