// Contravariance örneği
/*
 * Covariance ve Contravariance, birbirinden türetilmiş tiplerin kendi arasında tür dönüşümü yapılması, 
 * birbiriyle yer değiştirilebilmesi ve eşitlikleri gibi karşılaştığımız belirli durumlardır.
 * 
 * Contravariance: Küçük türlerin (less derived) daha büyük türlere (more derived) dönüştürülmesi durumu.
 */

class Vehicle { }
class Car : Vehicle { }
class Bus : Vehicle { }

class Contravariance
{
    static void Main(string[] args)
    {
        Action<Vehicle> vehicleAction = StartVehicle;
        Action<Car> carAction = StartCar;

        // Contravariance sayesinde, Action<Vehicle> türünden bir değişkene
        // Action<Car> türünden bir değer atanabilir.
        carAction = vehicleAction;

        Vehicle vehicle = new Vehicle();
        carAction(vehicle); // Hata verir, Vehicle türü için yazılmış metot çağrılamaz

        Car car = new Car();
        carAction(car); // Çalışır, Car türü için yazılmış metot çağrılabilir
    }

    static void StartVehicle(Vehicle vehicle) => Console.WriteLine("Starting vehicle...");
    static void StartCar(Car car) => Console.WriteLine("Starting car...");
}
