İÇECEK OTOMATI

Bu küçük OOP projesi bir içecek otomatına aittir ve oluşturulurken SOLID prensipleri göz önünde bulundurulmuştur.

Otomatta çay ve kahve türleri bulunmaktadır. 
Çay ve Kahve sınıfları İçecek sınıfından türemektedir.

SOLID prensiplerine dair neler yapıldığına ilişkin bir açıklama yapmak gerekirse;

Single Responsibility Principle (SRP): 
Drink sınıfında tanımlanan 4 farklı fonksiyon vardır. 
Bunlardan ikisi (Pour, Sell) makinenin çalışma şekli ile ilgiliyken diğer iki fonksiyon (Evaluate, Comment) kullanıcılardan feedback alınması ile ilgilidir.
Bu iki görev grubu birbirinden farklı olduğu için tek bir sınıfta tanımlanması doğru olmayacaktır. 
Single Responsibility Principle'da belirtildiği gibi her sınıf tek bir göreve sahip olmalıdır, "one reason to change" olarak da açıklanan bu durumda o sınıfın değişmesi için yalnızca bir sebep olmalıdır.
Bu amaç doğrultusunda DrinkEvaluation adı verilen yeni bir sınıf oluşturulmuştur ve kullanıcıların feedbackleri ile ilgili olan 2 fonksiyon (Comment, Evaluate) bu sınıfa taşınmıştır.
Böylelikle hem Drink hem de DrinkEvaluation sınıflarında Single Responsibility gereksinimi karşılanmıştır.

Open-Closed Principle:

Liskov Substitution Principle:

Interface Segregation Principle:

Dependency Inversion Principle:
