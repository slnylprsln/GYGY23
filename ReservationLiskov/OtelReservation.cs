
namespace ReservationLiskov 
{
    public class OtelReservation : Reservation, IPaymentCalculable
    {
        public string? OtelName;
        public int RoomNumber;
        public int RoomCapacity;
        public bool haveAirConditioner;

        public OtelReservation(int dayCount, DateTime startDate) : base(dayCount, startDate)
        {
            DayCount = dayCount;
            ReservationStartDate = startDate.ToLongDateString();
        }

        public void CalculatePayment()
        {
            int payment;
            if (haveAirConditioner) payment = DayCount * 1500;
            else payment = DayCount * 1250;
            Console.WriteLine($"Your total payment will be {payment} Turkish Liras for this {DayCount} days otel reservation.");
        }
    }
}
