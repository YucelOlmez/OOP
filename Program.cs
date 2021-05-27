using System;

namespace OOP
{
    class Program
    {

        #region Object Oriented Programming

        //OOP Kavramı bir yaklaşım bir felsefedir.
        //OOP bir teknoloji değildir.
        //Gerçek hayattaki tüm olguları programlama için simüle eden nesneleri baz alan bir programlama tekniğidir.
        //OOP her şeyi nesne olarak gören bir programlama yaklaşımıdır.
        //Gerçek bir sistem, nesnel parçalara ayrılır ve bu parçalar(nesneler) arasında ilişkiler kurulur.
        //Nesneler kendi aralarında haberleşebilirler.
        //OOP yaklaşımında yaklaşım olgusu bir olaya bir işe ya da yapıya yaklaşma biçimidir. Yaklaşım olgusu ilgili olaya işe yapıya hangi felsefe ile ele aldığımızı anlatır.(örn: Fonksiyonel yaklaşım, OOP yaklaşımı gibi...)
        //OOP'tan önce program tasarlayanlar her iş parçacığı için ayrı program dilleri yazıp bunların birbirleri ile entegrasyonunu sağlamaya çalışırlardı ve bu durum zaman zaman uyumsuzluk problemini ortaya çıkartırdı. Fakat OOP yaklaşımı ile beraber yazılım geliştirme süreçlerini oldukça kısaltan ve sistematik hale getiren süreç başlamış oldu.(Kompleks yaklaşımları daha anlaşılır sağlamıştır)
        //Nesnenin anatomisi önemlidir. 
        //OOP'ta en küçük esas parça object(nesne)dir.
        //nesneler içerisinde veri tutabilecekleri alanlar barındırır. Bu alanlara 'field' denir. Bu alanların sınırı yoktur. Tabi ki bellek dolana kadar...
        //Object içerisinde ilgili field'ların içerisindeki verileri işleyebilmek için function'lar vardır. Bu object'in kendisine ait içerisinde ekosistem barındırdığını söylememize sebeptir. İleride bu function'lara method, property indexer diyeceğiz. Bu field'lardaki verileri lazım olduğunda alıp işleyebileceğiz.
        //OOP destekleyen dillerde nesneyi oluşturabilmek için modellemek gerekmektedir. Nesneler esasında bire sınıf modellemesidir. Yani sınıf oluşturmamız gerekmektedir. object=class / object (nesne) class(sınıf)'ın ürünüdür.
        //Nesne Kavramı 
        //Nesne nesnellik felsefesine dayanan bir kavramdır. Kainattaki her şeyi nesne olarak görmek ve nesne olarak yorumlamak fikrine dayanır.
        //Nesne gerçek hayatta elle tutulur ve gözle görülebilir olduğu için dolayısı ile programlamada nesne günlük hayattaki nesnelerin muadilidir.
        //Gerçek hayattaki herhangi bir olguyu nesneyi objeyi programlama dünyasında tarif ederken onu gerçek hayattaki gibi nesne olarak tarif edecek ve o şekilde modelleyeceğiz.
        //Nesne Modellemesi
        //Nesnelerin oluşturulabilmesi için modellenmesi gerekmektedir.
        //Nesne modeli class ile gerçekleştirilir.
        //Örneğin araba modelleyeceksem öncelikle araba class'ı oluşturmalıyım. Daha sonra gerçek hayattaki araba ile simüle edip modellediğim araba arasındaki bütün ortak noktaları tanımlayıp ortaya bir nesne çıkartıyorum. Sonrasında ihtiyacım doğrultusunda yeni bir araba nesnesi üretim ona değer atayabiliyorum.
        //Nesneler referans türlü değişkenler kategorisine girmektedir. Nesneleri tutan değişkenler referans türlü değişkenlerdir. 
        //Nesne içerisinde bir ve yada birden fazla veri tutan değerler bütünüdür. Nesnelerin içerisindeki değerler/veriler yani field Heap'te tutulur. Aslen ilgili değerlerin bazıları değer türlü değişken olsa da değerin bağlı olduğu kavram object'i ilgilendirdiği için ilgili değer Heap'te tutulur.
        //NŞA biz developer'lar heap'te direkt erişimimiz yoktur, stack'a vardır. Bu doğrultuda stack üzerinden heap'e ulaşırız. Bu ulaşıma referans diyoruz. class'ta ürettiğimiz nesnenin pointeri(işaretçisi) stackte bulunur fakat ilgili nesnenin değerleri field içerisindeki değerler heap'te tutulur. örneğin carVolvo; nesnesini tek başına çağırdığımda stack'ten kendisi gelir ama carVolvo.Color dediğimde heap'teki değerine erişirim ve oraya değer atayabilirim.

        //Class Nedir ?
        //OOP'de bir object oluşturabilmek için öncelikle o object'in modellenmesi/tanımlanması gerekmektedir.
        //Bir object'in modelini/tanımını oluşturabilmek için class yapısı kullanılır.
        //Class dediğimz yapılanma bir nesnenin modelidir.
        //Class yapısı kendi içerisinde ilgili nesnenin içerisinde hangi değerlerin tutulacağına dair o alanları tanımlayabileceğimiz alanları tutmamızı sağlıyor.
        //Class'ı niye kullanıyoruz ? Class kodu yazdığımız inşaa ettiğimiz yerdir. Artık inşaa edilen kod çalışsın ve işlevselliğini göstersin dediğimizde ise object oluşturup bunu object'te çalıştırıyoruz. OOP'un temeli bu anlamda class'tır. Object'i oluşturabilmek için class'a ihtiyacımız vardır.
        //Class'larda nesnelerdeki ortak alan tanımlamaları yapılır
        //Classta üretecek olduğum nesnenin ortak özelliklerini belirledikten sonra ürettiğim nesnenin adını çağırıp .(nokta) tuşuna bastığımda ilgili nesnenin classta ortak özelliklerini belirlediğim field'ı gelecektir.
        //Tek bir object için 1 tane class tanımlayıp ilgili class merkezi üzerinden birden çok object üretebilirim. Örnek verecek olursam kalem class'ından 1 tane oluştururum ve kalem çeşitlerindeki ortak alanları kalem class'ında belirleyip sonrasında ilgili class üzerinden farklı kalem object'leri oluştururum. 1'den --> Çoğula giden bir akış vardır. 1 Kere simüle edip sonrasında tekrar tekrar üretirim. Fakat kalem class'ından araba object'i doğal olarak üretemem.
        //Class Nasıl Oluşturulur ?
        //Classlar bir referans türüdür. Oluşturduğumuz simüle ettiğimiz her ne ise o ve classa ismini verdiğimiz ne ise o bizim türümüzdür/türe karşılık gelir. Yani class araba ise araba türünden bir object oluşturmuş olacağım. Aslen yeni bir tür oluşturmuş oluyorum. Class 3 farklı yerde oluşturulur. Namespace içerisinde, Namespace Dışarısında ve Namespace'den bağımsız Class içerisinde(Nested Type[iç içe class'lar])
        //Aynı namespace içerisindeki classlar birbirleri ile direkt ismi ile erişilebilir iken farklı namespace adı altındaki classlar namespace ismi üzerinden erişim sağlayabiliyor.
        //namespace dışında tanımlanan classlara namespace belirtmeksizin direkt erişim sağlanabiliyor.
        //Bir class tanımlamasında tanımlanan yerde ((namespace olabilir namespace dışı olabilir ya da her hangi bir class(namespace içindekiler yada dışındakiler) olabilir)) aynı isimde birden fazla class tanımlanamaz ! 

        class ornekModel1
        {
            int aa1;  //oluşturduğum tür içerisindeki field dediğimiz alanlar burasıdır
            int bb1;  //   " "

            public void X()   //oluşturduğum tür içerisindeki fonksiyondur
            {
                Console.WriteLine(aa1 + " " + bb1);
            }
            public int Y()
            {

                return aa1 * bb1;
            }
        }
        //Yukarıdaki örnek sınıf tasarımından elde ettiğim türün içerisindeki field alanlarından object'ler üretip türün içerisinde yapmasını istediğim fonksiyonlar/metot ile field dedğimiz alanları yönetip kontrol edip verileri işleyebiliyorum. field'a gelecek değerleri yapmasını istediğim metotlar ile nesneyi kontrol edebiliyorum.

        //class Modelinden Referans Noktası Oluşturma
        //Referans: Stackte tutulan ve heapteki herhangi bir nesneyi işaretleyebilme özelliğine sahip olan referans noktası(değişken türü üzerinden bu işlem yapılıyor) denir. 
        //Bir class tanımlandığında o class adı bir türdür. Haliyle o türü kullanabilmek için direkt olarak class adını kullanmamız yeterlidir.
        //Oluşturduğumuz türün değişken türü gibi kullanabilmemin altında yatan sebep referans türlü değişken olmasından kaynaklanmaktadır.

        ornekModel1 model; //Null'dur  //oluşturduğum türden bir değişken tanımladım vu bu değişken olarak değiş referans noktası olarak isimlendireceğim.
                           //Eğerki bir referans noktasında herhangi bir nesne referans edilmiyorsa o referans null değere sahiptir. Heapte bir nesneyi işaretlemiyorsa null'dur.

        //Class Members
        //Class elemanları 2 çeşite ayrılır.
        //1-Class içerisinde tanımlanmasa dahi arka planda var olmaya devam eden yapılar(Default olarak gelenler) [Özelleştirilmiş Yapılar]
        //2-Tanımlandığında var olan yapılar
        //2-'den devam ediyorum. Field : OOP'ta nesne içerisinde değer/veri depoladığımız alanlardır. Class içerisinde salt olarak tanımlanan bir değişken var ise bu field'dir. Herhangi bir türden olabilir. Field'lar türüne özgü varsayılan değer alırlar. Field sadece ürettiğimiz class'ın scope'larında tanımlanır ve adlandırılır ve sadece o zaman üretilen object'in içerisinde bir alanı tutar.

        #endregion





















        static void Main(string[] args)
        {

        }
    }
}
