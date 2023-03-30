
namespace ReservationLiskov
{
    public class CarReservation : Reservation, IPaymentCalcutable
    {
        public string? CarBrand;
        public string? CarLicensePlate;

        public CarReservation(int dayCount, DateTime startDate) : base(dayCount, startDate)
        {
            DayCount = dayCount; 
            ReservationStartDate = startDate.ToLongDateString();
        }

        public void CalculatePayment()
        {
            int payment;
            if (CarBrand == "BMW") payment = DayCount * 750;
            else if (CarBrand == "Mercedes") payment = DayCount * 800;
            else if (CarBrand == "Toyota") payment = DayCount * 650;
            else payment = DayCount * 500;
            Console.WriteLine($"Your total payment will be {payment} Turkish Liras for this {DayCount} days car reservation.");
        }
    }
}
