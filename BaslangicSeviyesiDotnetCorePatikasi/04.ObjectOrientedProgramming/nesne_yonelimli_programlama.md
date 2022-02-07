# Ders 1 - OOP Nedir ?

- Nesneye yönelimli programlamanın temel amacı, ihtiyaç duyulan programı daha küçük parçalara bölüp, yönetilebilir ve değiştirilebilir hale getirmektir.

- OOP, gerçek hayat problemlerini yine gerçek hayatta var olan nesneler ve bu nesneler ile ilişkilendiren bir yaklaşımdır.

-  Faydaları:

    - Problemleri gerçek hayattak işlemlere göre modellediği için uygulaması kolay ve hızlıdır.

    - Programlar için net bir yapı sağlar.

    - "Don't Repeat Yourself" yani "Kendini Tekrar Etme" ilkesini kabul eder. Bu sayede kodun bakımı, düzenlenmesi ve hata ayıklaması kolaylaşmış olur.

    - Programa daha sonradan yeni özellikler ekleyebilme imkanı sağlar.

<br>

# Ders 2 - Sınıf ve Nesne Kavramları

### Nesne (Object) nedir ?

- Nesnelerin kendilerine ait nitelikleri ve davranışları vardır.

- Nitelik: Nesnelerin özellikleridir ve nesnenin mevcut durumunu tanımlar. Mesela bir kedinin rengi ve ağırlığı o kedinin nitelikleridir.

- Davranış: Nesnelerin kendilerine özgü yaptıkları hareketlerdir. 
Mesela bir kedinin ihtiyaç duyduğu otu koklayarak bulabilmesi gibi.
        
### Sınıf (Class) nedir ?

- Sınıflar bir problemi soyutlamak ve genelleştirmek için kullanılan yapılardır veya şablonlardır.

- Sınıflar, bir nesneye ait tüm özellikleri (nitelikler + davranışlar) temsil eder. 

### Modelleme        

- İnsanların problemleri çözmek için çözme işlemine başlamadan önce yapılan projelerdir. Oluşabilecek durumları test edebilmek için kullanılır.

- Projeleri kodlamaya başlamadn önce modellemek ve model üzerinden sistemi test etmek sistemmi güvenilir hale getirecek ve kodlamasını kolaylaştıracaktır.

<br>

# Ders 3 - UML Diyagramları

- Bilgisayar ortamında projeleri modellemek için yazılımcılar arasında standart bir modelleme dili olan **UML**'i (Unified Modeling Language) kullanır. 

- Faydaları:

    - Hataları kolaylıkla bulmamızı sağlar.

    - Kodlama kolaylığı sağlar.

    - Kullanılak tekrar kod sayısı ayırt edilebilir ve bu sayede verim sağlanır.

    - Mantıksal hataları azaltır.

    - Resmin tamamını görmemizi sağlar.

    - Karmaşık sistemlerde değişiklik yapmayı sağlar.

    - Proje içerisinde farklı diller kullanıldığında farklı geliştiricilerin aynı yerden faydalanabilmesini sağlar.

<br>

# Ders 5 - Encapsulation (Kapsülleme)

OOP 4 temel ilke üzerine kuruludur.

- Encapsulation (Kapsülleme)

- Inheritance (Kalıtım)

- Polymorphism (Çok biçimlilik)

- Abstraction (Soyutlama)

## Encapsulation (Kapsülleme)

- Bir sınıf içerisindeki nitelikleri ancak o sınıfa ait olan metotların değiştirebilmesini ve okunabilmesini savunur. Bu sayede nesnelerde anlamsızlıkların oluşması önlenir. Anlamsızlıktan kasıt örnek olarak kitap nesnesinde sayfa sayısı -10 olarak girildiinde bir anlamsızlık oluşur. Bunun önüne geçmek için `Setter` metotları kullanılabilir. Bu metotlar içerisinde anlamsızlık oluşabilecek durumları yöneterek nesnede anlamsızlıkların önüne geçeriz.

- Bunu sağlaman için erişim belirleyicilerin kullanımı önemlidir. 

    - Private 

    - Public 

    - Protected

    Burada kapsülleme yapılacaksa nitelikler private olarak tanımlanmalıdır. Private tanımlanan niteliklere ulabilmemiz için devreye `Getter` ve `Setter` metotlar devreye girer. Bu metotlar sayesinde kapsülleme işlemini gerçek anlamda gerçekleştirmiş oluruz.

<br>

# Ders 6 - Inheritance (Kalıtım)

Bir sınıfın bütün özelliklerinin (nitelik + davranış) kendisinden oluşturulan diğer sınıflara aktarılmasına denir. Aktarılan özellikler alt sınıflarda tekrar oluşturulmazlar.

 Kalıtımın önemli özelliği kendimizi tekrar etmemizi engellemesidir. Ortak özellikleri ata sınıfta toplayarak kod tekrarlarını azaltırız. Ayrıca bir değişiklik yapılacağı zaman da her yerde değişim yapmak yerine tek bir yerde yaparak verimli çalışma yapmış oluyoruz.

 <br>

 # Ders 7 - Polymorphism (Çokbiçimlilik)

 Kalıtmın olduğu yerde olur.
 Alt sınıfların, ata sınıfındaki metotlarını değiştirerek kullanılabilmesi diyebiliriz. Buna `Overriding` diyoruz. Atadan alınan metodu özelleştirerek yeni şekli ile kullanıp çeşitlilik sağlarız.

 Örnek olarak hayvan sınıfında "hayvanlar ses çıkarır" şekline bir motot olsun. Aynı zamanda hayvanlar sınıfından türetilen kuş ve kedi sınıfı olsun. Türetilen sınıflarda da "hayvanlar ses çıkarır" metodu erişilebiliyor olacak ama bu metodu override ederek özelleştirebiliriz. Yani kedi sınıfında "hayvanlar ses çıkarır" metodunu "kediler miyavlar" olarak kullanabiliriz. İstersek kuş sınıfında da değiştirip "kuşlar öter" şeklinde kullanabiliriz. Yukarıdaki durumda istersek türetilen sınıflarda polymorphism kullanmaya da biliriz.

<br>

 # Ders 8 - Abstraction (Soyutlama)

 Bir sınıftan nesne üretilmesini engellememizi sağlar. Üst sınıfta, alt sınıfta bulunmasını istediğimiz özellikleri tanımlarız ama detaylarını belirtmeyiz. Detayların türetilen sınıflarda uygulanmasını istediğimiz zaman soyutlama kullanırız.