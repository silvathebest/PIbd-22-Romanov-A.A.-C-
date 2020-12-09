using System;
using System.Runtime.Serialization;

namespace WindowsFormsCrane
{
    [Serializable]
    internal class ParkingOccupiedPlaceException : Exception
    {
        public ParkingOccupiedPlaceException()
        {
        }

        public ParkingOccupiedPlaceException(string message) : base(message)
        {
        }

        public ParkingOccupiedPlaceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParkingOccupiedPlaceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}