
namespace ReservationLiskov
{
    public class Reservation
    {
        public int DayCount;
        public string? ReservationStartDate;

        public Reservation(int dayCount, DateTime startDate)
        {
            DayCount = dayCount;
            ReservationStartDate = startDate.ToLongDateString();
        }
    }
}
