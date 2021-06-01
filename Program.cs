using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
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
            //OOP destekleyen dillerde nesneyi oluşturabilmek için modellemek gerekmektedir. Nesneler esasında birer sınıf modellemesidir. Yani sınıf oluşturmamız gerekmektedir. object=class / object (nesne) class(sınıf)'ın ürünüdür.
            //Nesne Kavramı 
            //Nesne nesnellik felsefesine dayanan bir kavramdır. Kainattaki her şeyi nesne olarak görmek ve nesne olarak yorumlamak fikrine dayanır.
            //Nesne gerçek hayatta elle tutulur ve gözle görülebilir olduğu için dolayısı ile programlamada nesne günlük hayattaki nesnelerin muadilidir.
            //Gerçek hayattaki herhangi bir olguyu nesneyi objeyi programlama dünyasında tarif ederken onu gerçek hayattaki gibi nesne olarak tarif edecek ve o şekilde modelleyeceğiz.
            //Nesne Modellemesi
            //Nesnelerin oluşturulabilmesi için modellenmesi gerekmektedir.
            //Nesne modeli class ile gerçekleştirilir.
            //Örneğin araba modelleyeceksem öncelikle araba class'ı oluşturmalıyım. Daha sonra gerçek hayattaki araba ile simüle edip modellediğim araba arasındaki bütün ortak noktaları tanımlayıp ortaya bir nesne çıkartıyorum. Sonrasında ihtiyacım doğrultusunda yeni bir araba nesnesi üretip ona değer atayabiliyorum.
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

            //class ornekModel1
            //{
            //   public int aa1;  //oluşturduğum tür içerisindeki field dediğimiz alanlar burasıdır
            //   public int bb1;  //   " "

            //    public void X()   //oluşturduğum tür içerisindeki fonksiyondur
            //    {
            //        Console.WriteLine(aa1 + " " + bb1);
            //    }
            //    public int Y()
            //    {

            //        return aa1 * bb1;
            //    }
            //}
            //Yukarıdaki örnek sınıf tasarımından elde ettiğim türün içerisindeki field alanlarından object'ler üretip türün içerisinde yapmasını istediğim fonksiyonlar/metot ile field dedğimiz alanları yönetip kontrol edip verileri işleyebiliyorum. field'a gelecek değerleri yapmasını istediğim metotlar ile nesneyi kontrol edebiliyorum.

            //class Modelinden Referans Noktası Oluşturma
            //Referans: Stackte tutulan ve heapteki herhangi bir nesneyi işaretleyebilme özelliğine sahip olan referans noktası(değişken türü üzerinden bu işlem yapılıyor) denir. 
            //Bir class tanımlandığında o class adı bir türdür. Haliyle o türü kullanabilmek için direkt olarak class adını kullanmamız yeterlidir.
            //Oluşturduğumuz türün değişken türü gibi kullanabilmemin altında yatan sebep referans türlü değişken olmasından kaynaklanmaktadır.

            ornekModel1 model; //Null'dur  //oluşturduğum türden bir değişken tanımladım ve bu değişken olarak değiş referans noktası olarak isimlendireceğim.
                               //Eğerki bir referans noktasında herhangi bir nesne referans edilmiyorsa o referans null değere sahiptir. Heapte bir nesneyi işaretlemiyorsa null'dur.

            //Class Members
            //Class elemanları 2 çeşite ayrılır.
            //1-Class içerisinde tanımlanmasa dahi arka planda var olmaya devam eden yapılar(Default olarak gelenler) [Özelleştirilmiş Yapılar]
            //2-Tanımlandığında var olan yapılar
            //2-'den devam ediyorum. Field : OOP'ta nesne içerisinde değer/veri depoladığımız alanlardır. Class içerisinde salt olarak tanımlanan bir değişken var ise bu field'dir. Herhangi bir türden olabilir. Field'lar türüne özgü varsayılan değer alırlar. Field sadece ürettiğimiz class'ın scope'larında tanımlanır ve adlandırılır ve sadece o zaman üretilen object'in içerisinde bir alanı tutar.

            ornekModel1 om11 = new ornekModel1();  //assign sağı HEAP'te solu Stack'te olacaktır.Aradaki referans pointer'i om1 değişkeni olacaktır.(Object oluşturuldu)
            om11.aa1 = 123;
            om11.bb1 = 12;
            //Class içerisine tanımlanmış değişkenler [field] türüne özgü default değeri direkt alacaktır.
            //Eğer değişken class dışında farklı yerlerde tanımlanıyorsa default değer vermez. compiler hata verecektir. Çünkü değer atanmayan bir değişkeni işleyemeyiz/kullanamayız.



            //Property
            //Object içerisinde özellik/property sağlar.
            //Property esasınsa özünde bir metottur. Algoritmik/programatik kodlarımızı inşaa ettiğimiz bir metottur.
            //Fakat metottan farkı parametre almamaktadır ve scope'ları içerisinde get ve set olmak üzere iki tane metot almaktadır.
            //Eğer property'e bir değer gönderiyorsam set bloğu tetiklenecektir ve ilgili değeri yakalayacaktır. 
            //Eğer property okunmak istenirse get bloğu tetiklenir ve ilgili bloktan değeri return edilir. 
            //Propert'in işlevsel açıdan metottan farkı yoktur. Fakat davranışsal olarak object üzerinde değer atama ve okuma işlemlerinde kullanılır.
            //Property==field ilişkisi vardır.
            //Biz developer olarak object içerisindeki field'lara direkt olarak erişim sağlanmasını istemeyiz.
            //Dolayısı ile field'lardaki verileri kontrollü olarak dışarıya çıkartmak isteriz.
            //İşte bu gibi durumda property'leri kullanabilir.
            //c# dışındaki programlama dillerinde bu kontrolü metotlar ile yapabiliyorken c# dahilinde bu durumu hem metotlar ile hemde sadece bu işlem için kontrolü property'ler ile yapabilir.
            //Field'lara erişimi ilgili field değişkenin başına public[erişilebilir] ve private[erişilemez] keyword'leri ile sağlanır.
            //Yani property yapısı field kontrolünü developarda tutmayı public ve private ile sağlamış olur.
            //property'lerin fieldlar üzerindeki bu kontrolüne Encapsulation(Kapsülleme/Sarmalama) diyoruz.
            //buradaki erişim mantığı uzak bir bilgisayardan olarak anlaşılmamalıdır. Benim class'ımı kullanan developar olarak anlaşılır. İlgili classımın object'i üzerindeki field alanına erişmek isteyen (atama/okuma işemleri) isteğinde bulunulduğunda burayı encapsulation yönetmi ile benim isteğim doğrultusunda erişilebilmesidir.
            //Encapsulation bir güvenlik duvarı olarak düşünülebilir. Field'larımızı korumamıza içerisindeki değerleri bizim kontrolümüzde dışarıya açmaya yarar.
            //Property ile field içerisindeki orjinal değerleri saklayabilirim ve encapsulation ile gerçek değerin okunmasına izin vermeden dışarıya eksik fazla gösterebilirim. Aynı şekilde atama işlemine izin verdiğimde ise direkt olarak dışarıdan gelen atama değerinin eksiğini yada fazlasını eklediğimi ilgili istek gönderen kişiye istediğim gibi gösterebilirim. (örn gerçek değeri 5 olan field'a dışarıdan 20 değeri atanım ilgili kiişiye bunu 25'miş gibi göstermem yada eksik göstermem gibi...) property dışarıya gönderir encapsulation orjinal değeri korur.
            //Encapsulation: bir nesne içerisindeki dataların(field'larda tutulan verilerin) dışarıya kontrollü bir şekilde açılması ve dışarıdan gelecek olan değerleri kontrollü şekilde ilgili fieldlara yerleştiren yapılanmadır. 
            //Property yapısı oluşturabilmenin yapısal olarak bir kaç yolu vardır. Full property, Prop, Auto Property Initializers, Ref Readonly Return, Computed(Hesaplanmış) Properties, Expression-Bodied Property[-Read Only Property], Init Only Properties ve Init Accessor[c# 9.0]

            //Full Property
            //En sade yalın property yapılanmasıdır.
            //İçerisinde get ve set metotları scopeları tanımlanmalıdır.
            //get: property'den veri istendiğinde tetiklenir. set: property'e veri gönderildiğinde tetiklenir. value keyword'ü ile yakalar.
            //Full propertylerde set bloğu tanımlanmazsa get bloğu kalır ve sadece yazılabilir (read only), get bloğu tanımlanmazsa set bloğu kalır ve sadece okunabilir (write only) olacaktır.
            //Eğer Property ile field'larımı kontrollü bir şekilde dışarıya açacaksam object üzerinden bu field'lara erişilmemesi gerekmektedir. Yani encapsulation yapacaksam object üzerinden erişimin sağlanmaması gerekmektedir.
            // [[Eğer nesne üzerinden field'lara erişim sağlayabilmek istiyorsan field'ın başına ''public'' keyword'ü eklemeliyiz.]]
            //Property'ler hangi field'ları temsil ediyorsa ilgili field'in türü ile aynı olmak zorundadır. Property field'in türünden değer alacak.
            //Property isimlendirmesi genellikle temsil ettiği field'ın isminin baş harfi büyük olan olarak isimlendirilir. field name: renk ise property Renk... sebebi capsulation yaptığı field'a ithafen olduğuna sirayet eder.
            ornekModel1 om22 = new ornekModel1();
            Console.WriteLine(om22.Aa1); //get bloğu tetiklenir okunur
            om22.Aa1 = 1000; //set bloğu tetiklenir assing işlemi yapıldı.

            #region Metot
            ornekModel1 metotModel =new ornekModel1(); //Metot region2ı için oluşturulan nesnedir.
            metotModel.XX();   //Metot region'indaki oluşturduğum metottur.
            metotModel.Cc1 = "Yücel";  //Property'ler ingiliz anahtarı ile gösterilir.
            #endregion

            #region Indexer
            ornekModel1 indXer = new ornekModel1();
            indXer[5] = 10;
            #endregion


            #region Class içerisinde tanımlanan Class Sınıf Elemanı mıdır ?
            //Class elemanları field, property, metot ve indexer'dır.
            //Class içerisinde tanımlanan class(nested Type) eğer class member'i olsaydı classtan oluşturulan nesnenin içerisinde oluşturulan class'a bir şekilde ulaşılırdı. 
            //Peki Class içerisinde tanımlanan class'a erişim sağlayabilmek için hangi class isminin altında tanımladıysak ilgili class'ın üzerinden erişim sağlarız.
            #endregion

            #region this Keyword'ü
            //this keyword'ü ilgili class yapılanmasının o anki nesnesine karşılık gelir.
            //this kullanmak zorunda değiliz.
            //Kullanmadığımızda compiler arka planda onu otomatik kendisi oluşturup kullanıyor.
            //Fakat aşşağıdaki durumlarda kullanmamız gerekebilir.

            //Sınıfın Nesnesini Temsil Eder
            //Sınıf içerisinde kullanılan sınıfın içerisindeki member'larda kullanılan keyword'dür. Property metot indexer ya da constructer içerisinde kullanılır.
            //Bir classtan ürettiğimiz nesneyi eğer kendi sınıfında temsil etmek istiyorsak this keyword'ünü kullanırız.
            //Nesne üzerinden eriştiğimiz this keyword'ü nesne modellemesi üzerinden temsil etmemizi sağlar.

            ornekModel1 thisModel = new ornekModel1();
            thisModel.XX();

            //Aynı İsimde Field ile Metot Parametrelerini Ayırmak İçin Kullanılır
            //Bazen field'a verdiğimiz isimler ile kullanmakta olduğumuz metotun parametre isimleri nadiren aynı olabiliyor. Bu durumu engellemek için ilgili metotun parametresine değilde bulunduğu class içerisindeki field ismine erişmek istediğimizde metot scopelarında (this.aa1) dememiz yeterlidir.
            //this keyword'ü ilgili class yapılanmasının o anki nesnesine karşılık gelir.
            //this kullanmak zorunda değiliz.
            //Kullanmadığımızda compiler arka planda onu otomatik kendisi oluşturup kullanıyor.


            //Bir constructer'dan Başka Bir Constructer2ı Çağırmak İçin Kullanulır
            //Yapıcı Fonksiyonlar / Kurucu Fonksiyonlardır
            //Devasa mimariler kurmamızı sağlar.
            //Mimarisel bir manevra yapmamızı sağlar.
            //Constructer konusu geldiğinde yeniden this keyword'ü kullanılacaktır.

            #endregion



            #endregion
        }

        /// <summary>
        /// örnek Class'tır
        /// </summary>
        class ornekModel1
        {
            /// <summary>
            /// örnek field'dır
            /// </summary>
            public int aa1;  //oluşturduğum tür içerisindeki field dediğimiz alanlar burasıdır (Access Modifiers[erişim belirleyicisidir]Public keyword'ü oluşturduğumuz object'in, fieldlarına erişmemizi sağlar)
            /// <summary>
            /// örnek field'dır.
            /// </summary>
            public int bb1;  //   " "
            /// <summary>
            /// örnek Field'dır.
            /// </summary>
            public string cc1;

            #region Full Property
            //Full property'de field alanlarımız erişilebilir değildi ve public keyword'ü kullanılmaz.
          public int Aa1
          {
            get
            {
                //Property üzerinden değer talep edildiğinde get bloğu tetiklenir. Yani değer buradan gönderilir. geri dönüş değerine sahip bir metot eğer geriye return yapmıyorsa hata verir.
                return aa1;
            }
            set
            {
                    aa1 = value; //Gönderilen değer value keyword'ü ile yakalanır. Property'in türü ne ise ilgili türe bürünecektir.
            }
          }
            #endregion

            #region Prop Property
            //Bie property her ne kadar encapsulation yapsa da temsil ettiği field'daki dataya hiç müdehale etmeden erişilmesini ve veri atamasını sağlıyorsa böyle bir durumda kullanulan property imzasıdır.
            //Developer'lar field'daki değere müdehale yapılsın ya da yapılmasın direkt erişim yapılmasını istemeyiz.
            //Prop property'ler compile edildiklerinde arkaplanda kendi field'larını oluştururlar. Dolayısı ile bir field tanımlamaya gerek yoktur.
            //Prop imzalarda property read only olabilir fakat write only olamaz. Yani get bloğu olmadığında set bloğunu yalnız başına kullanamam. İkisini aynı anda kullanabilirim. set'i kullanamamamın sebebi okunabilir olmayan bir field'a nasıl atama yapabilirim ? Yapamam.
            //Prop imzada tanımlanan 1 field için property'de kontrol yapılmadığı için gelen değeri atıyor atanan değeride sadece okuyacaktır.
            public int Bb1 { get; set; }
            #endregion

            #region Auto Property Initializers (c# 6.0)
            //Bir property'in ilk değerini nesne ayağa kalktığı an verebiliyoruz.
            //Normalde oluşturulan field alanına uygun türde default değeri gelirken buna müdehale edip kontrol edebiliyoruz.
            //Auto Property Initializers özelliği sayesinde read only olan proplara hızlıca değer atanabilmektedir.
            public string Cc1 { get; set; } = "Ölmez";

            #endregion

            #region Ref Readonly Returns
            //İleride daha detaylı işleyeceğiz
            //Property tanımlamalarında nadirende olsa bu syntax görülebilyor.
            //Class'tan nesne oluşturdukça arka planda oluşturduğumuz nesne sayısının içindeki propertyler kadar field alanı RAM'de ayrılıyor. Bu maliyetli bir durumdur. Bunun yerine ilgili field'in referansını döndürmek ve sadece okunabilir olması amacıyla Ref Readonly Returns oluşturulmuştur.
            string adi = "Kallavi";
            public ref readonly string Adi => ref adi; //Burası  ornekModel1 Class'ı içerisinde olup bu class üzerinden Adi property'si üzerinden "Kallavi" değerine değil, bu değerin tutulduğu field'a erişeceğim. Yani "adi" field'ina erişmiş oluyorum.
                                                       //DETAYLI OLARAK ÖĞRENİLECEKTİR.

            #endregion

            #region Computed Property (Hesaplanmış)
            //İçerisinde türetilmiş bir bağıntı yaşıyan property'lerdir.
            //Capsulation yaaparken tek bir field üzerine değil de bu field'lar üzerinden bir bağıntı yaparak capsulation yapıyor.
            int comP = 5;
            int comP1 = 123;
            public int Topla //Hepsaplama yapan propertydir. Her toplayı çağırıdğıumda comP ile comP1 toplamını geriye döndürür.
            {
                get
                {
                    return comP + comP1;  
                }
            }
            #endregion

            #region Expression-Bodied Property 
            //Tanımlanan property'lerde lambda expression kullanmamızı sağlayan sözdizimidir.
            //Sadece read only olan property'lerde kullanılır.
            //Sadece değer döndürecekse bu şekilde kullanım uygun olacaktır.
            //Auto Property Initializers ile akrabadır. İkisinde de ilk değeri alırlar.
            public string soyIsım => "Ölmez";
            #endregion

            #region Init-Only Properties [Init Accessor c#9.0]
            //Nesnenin ilk yaratılış anında property'lerine değer atamaktadır.
            //Ayrı bir başlık altında değerlendirilmesi gereken bir yapıdır. 
            //Auto Property Initializers İle yapılabiliyor. Fakat fark vardır.
            //run time'da değeri değişmemesi gereken nesneler için bir önlem alınmaktadır.
            //Developer açısından gelişim süreç esnasında değiştirilmemesi gereken değerlerin ''yanlışlıkla'' değiştirilmesinin önüne geçmekte ve olası hata [bug]'lardan yazılımı arındırmaktadır.
            //property'de {get; init;} = "Victor Hugo" şeklinde kullanımı vardır. property'e verilen ilk değerler atandıktan sonra init tarafından bu alan kitlenir ve değer koruma altına alınır. Değiştirilmesi halinde hata verir, altı kırmızı çizer.
            // bu özelliği kullanabilmek için init keyword'ü kullanılacak ve nasıl kullanacağı zamanı geldiğinde öğrenilecektir.
            #endregion

            #region Metot
            //Nesne üzerinde field'lardaki değerler de ya da dışarıdan parametreler ile gelen değerler üzerinde işlemler yapmamızı sağlayan temel programatik parçalardır.
            //metotlar geri dönüş türü alma zorunda değildir. Fakat alabilirler
            //Fakat propertyler kesinlike geri dönüş türü almalıdırlar. Çünkü capsulation yaparken hangi türde yapacağini bilmek ister.
            public int XX()
            {
                this.XX();
                return 0;
            }


            #endregion

            #region Indexer
            //bir class'ın nesnesine indexer özelliği kazandırmak istiyorsam 'this []' keyword'ü ile oluşturulur.
            //Nesneye indexer özelliği kazandıran yapısal olarak property ile birebire aynı olan yapıdır.
            public int this[int a]
            {
                get
                {
                    return a;
                }
                set 
                {
                   a=value;
                }
            }
            #endregion

            /// <summary>
            /// örnek metottur
            /// </summary>
              public void X()   //oluşturduğum tür içerisindeki fonksiyondur
              {
                Console.WriteLine(aa1 + " " + bb1);
              }
            /// <summary>
            /// örnek metottur.
            /// </summary>
            /// <param name="AAA">AAA parametresidir</param>
            /// <returns>aa1*bb1</returns>
              public int Y(int AAA)
              {
                

                return aa1 * bb1;
              }
        }
    }
}
