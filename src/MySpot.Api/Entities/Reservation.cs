using MySpot.Api.Exceptions;

namespace MySpot.Api.Entities
{
    public class Reservation
    {
        public Guid Id { get; }
        public string EmployeeName { get; private set; }
        public Guid ParkingSpotId { get; private set; }
        public string LicensePlate { get; private set; }
        public DateTime Date { get; private set; }

        public Reservation(Guid id, Guid parkingSpotId, string employeeName, string licensePlate, DateTime date)
        {
            Id = id;
            EmployeeName = employeeName;
            ChangeLicencePlate(licensePlate);
            Date = date;
            ParkingSpotId = parkingSpotId;
        }

        public void ChangeLicencePlate(string licensePlate)
        {
            if (string.IsNullOrWhiteSpace(licensePlate))
            {
                throw new EmptyLicensePlateException();
            }

            LicensePlate = licensePlate;
        }
    }
}
