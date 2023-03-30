
namespace ReservationLiskov
{
    public class SeminarRoomReservation : Reservation, IPaymentCalculable
    {
        public string? SeminarRoomName;
        public int SeminarRoomCapacity;
        public string? SeminarRoomDescription;
        public bool haveBoard;

        public SeminarRoomReservation(int dayCount, DateTime startDate) : base(dayCount, startDate)
        {
            DayCount = dayCount;
            ReservationStartDate = startDate.ToLongDateString();
        }

        public void CalculatePayment()
        {
            int payment;
            if (SeminarRoomCapacity <= 50) payment = DayCount * 200;
            else if (SeminarRoomCapacity > 50 && SeminarRoomCapacity <= 100) payment = DayCount * 500;
            else if (SeminarRoomCapacity > 100 && SeminarRoomCapacity <= 250) payment = DayCount * 900;
            else if (SeminarRoomCapacity > 250 && SeminarRoomCapacity <= 500) payment = DayCount * 2000;
            else payment = DayCount * 3000;
            Console.WriteLine($"Your total payment will be {payment} Turkish Liras for this {DayCount} days seminar room reservation.");
        }
    }
}
