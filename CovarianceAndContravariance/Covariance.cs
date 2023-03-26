// Covariance örneği
/*
 * Covariance ve Contravariance, birbirinden türetilmiş tiplerin kendi arasında tür dönüşümü yapılması, 
 * birbiriyle yer değiştirilebilmesi ve eşitlikleri gibi karşılaştığımız belirli durumlardır.
 * 
 * Covariance: Geniş türlerin (more derived) daha küçük türlere (less derived) dönüştürülmesi durumu.
 */

class Animal { }
class Cat : Animal { }

class Covariance
{
    static void Main(string[] args)
    {
        Func<Animal> animalFactory = CreateAnimal;
        Func<Cat> catFactory = CreateCat;

        // Covariance sayesinde, Func<Animal> türünden bir değişkene
        // Func<Cat> türünden bir değer atanabilir.
        animalFactory = catFactory;

        Animal animal = animalFactory();

        Console.WriteLine(animal.GetType());
    }

    static Animal CreateAnimal() => new Animal();
    static Cat CreateCat() => new Cat();
}
