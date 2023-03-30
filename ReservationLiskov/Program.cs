
using ReservationLiskov;

CarReservation carReservation = new(7, DateTime.Now)
{
    CarBrand = "BMW"
};
carReservation.CalculatePayment();

OtelReservation otelReservation = new(5, DateTime.Now)
{
    haveAirConditioner = true
};
otelReservation.CalculatePayment();

SeminarRoomReservation seminarReservation = new(2, DateTime.Now)
{
    SeminarRoomCapacity = 320
};
seminarReservation.CalculatePayment();
