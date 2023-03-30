# İÇECEK OTOMATI

Bu küçük OOP projesi bir içecek otomatına aittir ve oluşturulurken SOLID prensipleri göz önünde bulundurulmuştur.

Otomatta çay ve kahve türleri bulunmaktadır. 
Çay ve Kahve sınıfları İçecek sınıfından türemektedir.

SOLID prensiplerine dair neler yapıldığına ilişkin bir açıklama yapmak gerekirse;

### **Single Responsibility Principle (SRP)** 
Drink sınıfında tanımlanan 5 farklı fonksiyon vardır. Bunlardan üçü (Pour, Sell, ShowDrinks) makinenin çalışma şekli ile ilgiliyken diğer iki fonksiyon (Evaluate, Comment) kullanıcılardan feedback alınması ile ilgilidir. Bu iki görev grubu birbirinden farklı olduğu için tek bir sınıfta tanımlanması doğru olmayacaktır. Single Responsibility Principle'da belirtildiği gibi her sınıf tek bir göreve sahip olmalıdır, "one reason to change" olarak da açıklanan bu durumda o sınıfın değişmesi için yalnızca bir sebep olmalıdır. Bu amaç doğrultusunda DrinkEvaluation adı verilen yeni bir sınıf oluşturulmuştur ve kullanıcıların feedbackleri ile ilgili olan 2 fonksiyon (Comment, Evaluate) bu sınıfa taşınmıştır. Böylelikle hem Drink hem de DrinkEvaluation sınıflarında Single Responsibility gereksinimi karşılanmıştır.

### **Open-Closed Principle (OCP)** 
Coffee ve Tea sınıflarında ortak bir fonksiyon vardır. Bu fonksiyon sıcak içecek olup olmadığını döndürmektedir. Adı "isHotBeverage" olan bu fonksiyon, Drink sınıfında hem Coffee hem de Tea için ayrı ayrı tanımlanabilirdi fakat bu Open-Closed Principle'a aykırı bir durum yaratırdı. O şekilde yapıldığında, her yeni sıcak içecek türü eklendiğinde Drink sınıfında yeni bir fonksiyon yazmak zorunda kalınırdı ve bu da halihazırda bulunan kodun sürekli modifiye edilmesi anlamına gelir. Fakat Open-Closed Principle şunu önermektedir: Sınıflar genişlemeye açık olmalıdır fakat modifiye edilmeye kapalı olmalıdır. Her içecek türü eklenmesinde kodu modifiye etmek zorunda kalınması bu prensiple örtüşmez.

### **Liskov Substitution Principle (LSP)** 
LSP'de de OCP'de olduğu gibi genişlemeye açık yapılar söz konusudur. LSP'nin genel mantığı; alt sınıflardan oluşan nesnelerin üst sınıfın nesneleri ile yer değiştirdikleri zaman, aynı davranışı sergilemesini beklemektir. Mesela bu projede en genel sınıf olan Drink sınıfı 3 adet alt sınıf içermektedir. Bunlardan ikisi (Tea, Coffee) ekstra şeker eklenebilme özelliğine sahiptir ve bunun fonksiyonunu içermektedirler. Bu fonksiyonu direkt olarak Drink sınıfında tanımlamak doğru değildir çünkü orda tanımlandığı zaman şeker eklenebilme özelliği olmayan Soda sınıfı için de bu fonksiyon kullanılabilir olacaktır. Fakat istenen şey bu değildir. Soda da bir içecek olmasına rağmen diğer ikisinden farklı olarak ekstra şeker eklenemez durumdadır ve ona bu fonksiyonun kullandırılması kodda karmaşıklığa sebep açacaktır. Kullanıcılara; sodaya şeker eklemek bir seçenek olarak görünecektir, aslında öyle bir seçenek olmamasına rağmen.

### **Interface Segregation Principle (ISP)** 
Drink sınıfında bulunan 5 fonksiyon 2 farklı Interface'te (IDrink, IDrinkEvaluation) tanımlanmıştır. Bunun sebebi Drink ve DrinkEvaluation olmak üzere 2 farklı sınıfa sahip olunmasıdır. Bu 2 sınıfta ortak 2 fonksiyon bulunmasına rağmen tek bir Interface kullanılmamıştır. Bunun sebebi ise toplu bir şekilde 5 fonksiyon içeren bir Interface yazılması durumunda, DrinkEvaluation sınıfında 3 tane Unimplemented fonksiyon bulundurmak zorunda kalınacağı gerçeğidir. Interface Segregation Principle'ın da önerdiği üzere, hiçbir sınıf kullanmayacağı fonksiyonu kullanmak zorunda bırakılmamalıdır. 

### **Dependency Inversion Principle (DIP)** 
Dependency Inversion Principle'ın önermesine göre high level sınıflar low level sınıflara bağımlı olmamalıdır. Bu projede bunun sağlanması için, halihazırda var olan DrinkRepository sınıfı ile Drink sınıfı arasında bir IDrinkRepository interface'i tanımlanmıştır. Bu interface'in Drink sınıfında kullanılabilmesi için ise bir factory sınıfı (DrinkFactory) oluşturulmuştur. Bu sayede, DIP'e aykırı oluşabilecek durumlar engellenmiştir.
