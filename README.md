# Design Patterns

Bir tasarım deseni, yazılım tasarımında yaygın olarak ortaya çıkan bir soruna genel olarak tekrarlanabilir bir çözümdür. Bir tasarım deseni, doğrudan koda dönüştürülebilen bitmiş bir tasarım değildir. Birçok farklı durumda kullanılabilecek bir problemin nasıl çözüleceğine dair bir açıklama veya şablondur.

## Creational Patterns - Yaratılış Desenler

Yaratıcı tasarım kalıpları, duruma uygun bir şekilde nesneler yaratmaya çalışan, nesne oluşturma mekanizmalarıyla ilgilenen tasarım kalıplarıdır. Temel nesne oluşturma biçimi, tasarım sorunlarına veya tasarıma ek karmaşıklıklara neden olabilir. Yaratıcı tasarım kalıpları, bu nesne oluşumunu bir şekilde kontrol ederek bu sorunu çözer.

### [Builder](https://github.com/Hilal-aslanboga/Design_Patterns/tree/master/Creational_Patterns/Builder)

Bu tasarım şablonu, bir nesnenin oluşum aşamasında farklı nesnelere de ihtiyaç olduğu durumlarda kullanılır. Yani karmaşık yapıdaki bir nesne, değişik özelliklerin(nesnelerin) bir araya gelmesiyle oluşur. Birden fazla adım barındıran nesne üretim sürecinde, farklı parçalar birleştirilir ve istenilen tipteki nesne oluşturulmuş olur.

![Builder](https://user-images.githubusercontent.com/79503027/113909215-1b372780-97e0-11eb-8294-52f55f9daa9c.png)


### [Factory](https://github.com/Hilal-aslanboga/Design_Patterns/tree/master/Creational_Patterns/FactoryMethod)

Factory tasarım deseni,creational tasarım desenlerinden biridir. Bu tasarım deseni bir nesne yaratmak için arayüz sağlar ve hangi sınıftan nesne yaratılacağını alt sınıfların belirlemesine olanak tanır. Asıl amaç oluşturmak istediğimiz sınıfların tek tek instance oluşturmak yerine bu oluşturma işlemini tek bir sınıf üzerinden yönetmek.

![Factory](https://user-images.githubusercontent.com/79503027/113909244-21c59f00-97e0-11eb-98de-ffb475765891.png)


### [Singleton](https://github.com/Hilal-aslanboga/Design_Patterns/tree/master/Creational_Patterns/Singleton)

Singleton(tek nesne) tasarım kalıbı, bir sınıfın tek bir örneğini almak için kullanılır.Amaç oluşturulan nesneye global erişim noktası sağlamaktır.Sistem çalıştığı sürece ikinci bir örnek oluşturulmaz, böylelikle istenen nesnenin tek bir defa oluşturulması garanti altına alınacaktır.Singleton nesneler ilk çağırıldıklarında bir kere oluşturulurlar ve sonraki istekler bu nesne üzerinden karşılanır.

![Singleton](https://user-images.githubusercontent.com/79503027/113908748-8f250000-97df-11eb-8c6c-2d9858345fe6.png)

## Structural Patterns - Yapısal Desenler

Yapısal Tasarım Modelleri, varlıklar arasındaki ilişkileri gerçekleştirmenin basit bir yolunu belirleyerek tasarımı kolaylaştıran Tasarım Modelleridir.

### [Adapter](https://github.com/Hilal-aslanboga/Design_Patterns/tree/master/Structural_Patterns/Adapter)

![Adapter](https://user-images.githubusercontent.com/79503027/113909269-29854380-97e0-11eb-998a-f7dc57c14b70.png)


### [Bridge](https://github.com/Hilal-aslanboga/Design_Patterns/tree/master/Structural_Patterns/Bridge)

![Bridge](https://user-images.githubusercontent.com/79503027/113909288-3013bb00-97e0-11eb-82c2-f9b3a80d727e.png)

### [Decorator](https://github.com/Hilal-aslanboga/Design_Patterns/tree/master/Structural_Patterns/Decorator)

![Decorator](https://user-images.githubusercontent.com/79503027/113909299-343fd880-97e0-11eb-8746-b91f33735b11.png)

## Behavioral Patterns - Davranış Desenler

Davranışsal tasarım kalıpları, nesneler arasındaki ortak iletişim kalıplarını tanımlayan ve bu kalıpları gerçekleştiren tasarım kalıplarıdır. Bunu yaparak, bu modeller bu iletişimin gerçekleştirilmesindeki esnekliği artırır.

### [ChainofResponsibility](https://github.com/Hilal-aslanboga/Design_Patterns/tree/master/Behavioral_Patterns/ChainofResponsibility)

![Chainofresponsibility](https://user-images.githubusercontent.com/79503027/113909359-41f55e00-97e0-11eb-89a5-0e50131f8c40.png)


### [Mediator](https://github.com/Hilal-aslanboga/Design_Patterns/tree/master/Behavioral_Patterns/Mediator)

![Mediator](https://user-images.githubusercontent.com/79503027/113909380-4752a880-97e0-11eb-8ad1-06da7b6fa2c8.png)


### [Observer](https://github.com/Hilal-aslanboga/Design_Patterns/tree/master/Behavioral_Patterns/Observer)

![Observer](https://user-images.githubusercontent.com/79503027/113909389-4ae62f80-97e0-11eb-9124-5d782136288f.png)

