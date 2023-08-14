/* C# Notları 

--Değişkenler: Programlama dillerinde, değişkenler değerleri depolamak, manipüle etmek ve yönetmek için temel yapı taşları olarak kullanılır.
--Veri Tipleri: Değişkenler tarafından depolanan değerin türünü belirtir.

int: Tam sayıları depolamak için kullanılır. -> int yaş = 30;
long: Daha büyük tam sayıları depolamak için kullanılır. -> long nüfus = 7894561230L;
double: Ondalık sayıları depolamak için kullanılır -> double maaş = 2500.50;
float: Ondalık sayıları depolamak için kullanılır -> float sıcaklık = 25.5f;
string: Metinleri depolamak için kullanılır. -> string isim = "Alice";
char: Tek bir karakteri depolamak için kullanılır. -> char cinsiyet = 'F';
bool: Mantıksal değerleri (doğru/yanlış) depolamak için kullanılır -> bool aktifMi = true;

--------------------------------------------------------

--Operatörler: Operatörler, programlama dillerinde değişkenler ve değerler üzerinde çeşitli işlemler gerçekleştirmek için kullanılan semboller veya sembol kombinasyonlarıdır.
+  İki değeri toplar.
- Bir değeri diğerinden çıkarır.
*  İki değeri çarpar.
/ Bir değeri diğerine böler.
%  Bölme işleminin kalanını verir.
&& Her iki koşul da doğru ise true döner.
|| (OR): En az bir koşul doğru ise true döner.
! (NOT): Bir koşulun tersini döndürür.
== (Equal to): İki değer eşitse true döner.
!= (Not equal to): İki değer eşit değilse true döner.
> (Greater than):  Sol taraftaki değer, sağ taraftaki değerden büyükse true döner.
< (Less than):  Sol taraftaki değer, sağ taraftaki değerden küçükse true döner. 
>= (Greater than or equal to): Sol taraftaki değer, sağ taraftaki değerden büyük veya eşitse true döner.
<= (Less than or equal to): Sol taraftaki değer, sağ taraftaki değerden küçük veya eşitse true döner.
= (Assignment):  Bir değişkene bir değer atar.
+= (Add and assign): Bir değişkenin mevcut değerine başka bir değer ekler ve sonucu değişkene atar.
-= (Subtract and assign): Bir değişkenin mevcut değerinden başka bir değeri çıkarır ve sonucu değişkene atar.
?: (Conditional Operator): Bir koşulu değerlendirir ve doğru ise bir değer, yanlış ise başka bir değer döndürür.
++ (Increment): Bir değişkenin değerini bir artırır.
-- (Decrement):  Bir değişkenin değerini bir azaltır.

--------------------------------------------------------

--Döngüler: Döngüler, programlamada bir kod bloğunu tekrar tekrar çalıştırmanıza olanak tanıyan temel yapılardır. Tekrarlayan görevleri otomatikleştirmeye yardımcı olur ve kodu daha verimli hale getirir.

for Döngüsü: Syntax: for (başlatma; koşul; artış) { // yürütülecek kod }
while Döngüsü: Syntax: while (koşul) { // yürütülecek kod }
do-while Döngüsü: Syntax: do { // yürütülecek kod } while (koşul);
foreach Döngüsü: Syntax: foreach (var öğe in koleksiyon) { // yürütülecek kod }
--------------------------------------------------------

--Decision Structures:Decision structures, also known as control structures or conditional statements, allow you to make decisions based on certain conditions. They control the flow of the program by executing different code blocks depending on whether a condition is true or false.

if Statement:
if (koşul) 
{
   // koşul doğruysa
}

-----

if-else Statement:
if (koşul) 
{
   // koşul doğruysa
} 
else 
{
   // koşul yanlışsa
}

-----

switch Statement:

switch (expression) 
{
   case value1:
       // code to execute for value1
       break;
   case value2:
       // code to execute for value2
       break;
   // ... more cases ...
   default:
       // code to execute if no case matches
       break;
}

--------------------------------------------------------


--Diziler: Diziler, C#'da temel veri yapılarıdır ve aynı veri türünden bir öğe koleksiyonunu tek bir değişken adı altında depolamanızı sağlar. Birden çok değeri sıralı bir şekilde yönetme ve bunlara erişme için organize bir yol sağlarlar.

Sözdizimi: int[] numbers = new int[5];

int[] primes = { 2, 3, 5, 7, 11 }; // Belirtilen değerlerle bir dizi başlatır

--------------------------------------------------------

--Listeler: C#'da bir liste, aynı veri türünden öğeler depolayabilen dinamik bir koleksiyondur. Listeler, ilgili nesne gruplarını yönetmek için esnek ve boyutu değiştirilebilir bir yol sağlar.

Sözdizimi: List<VeriTürü> listeAdı = new List<VeriTürü>();

List<int> numbers = new List<int>();

Diziler sabit boyutlu veri yapıları, listeler ise değişken boyutlu veri yapılarıdır.

--------------------------------------------------------

--Dictionary: Bir sözlük, anahtar-değer çiftleri koleksiyonudur. Anahtar, değeri aramak için kullanılır ve değer herhangi bir türden nesne olabilir.

Sözdizimi: Dictionary<AnahtarTürü, DeğerTürü> sözlükAdı = new Dictionary<AnahtarTürü, DeğerTürü>();

Dictionary<string, int> myDictionary = new Dictionary<string, int>();

--------------------------------------------------------

--Queue:Bir kuyruk, İlk Giren İlk Çıkar (FIFO) ilkesine uyar.

Syntax: Queue<VeriTürü> kuyrukAdı = new Queue<VeriTürü>();

Queue<int> myQueue = new Queue<int>();

--------------------------------------------------------

--Stack: Bir yığın, Son Giren İlk Çıkar (LIFO) ilkesine uyar.

Syntax: Stack<VeriTürü> yığınAdı = new Stack<VeriTürü>();

Stack<string> myStack = new Stack<string>()

--------------------------------------------------------

--Functions:Programlamada, fonksiyonlar belirli görevleri yerine getiren yeniden kullanılabilir kod bloklarıdır.

Syntax:
returnType fonksiyonAdı(parametreler)
{
// Kod bloğu
// Belirli bir görevi gerçekleştirmek için ifadeler
return sonuç; // Fonksiyonun bir dönüş türü varsa isteğe bağlı
}

--------------------------------------------------------

Sınıf: Nesnelerin yapısını ve davranışını tanımlayan bir taslaktır. Sınıfın nesnelerinin sahip olacağı özellikleri (öznitelikler) ve yöntemleri belirtir.

Nesne: Bir sınıfın örneğidir. Nesneler, gerçek dünya varlıklarını temsil eder ve tanımlanmış yöntemler kullanarak veri saklayabilir ve manipüle edebilir.

Kapsülleme: Verileri (öznitelikleri) ve veriler üzerinde çalışan yöntemleri tek bir birime (sınıf) paketleme. Verilere erişim, erişim değiştiricileri (public, private vb.) ile kontrol edilir.

Kalıtım: Yeni bir sınıfın (alt sınıf veya türetilmiş sınıf) var olan bir sınıftan (temel sınıf veya üst sınıf) özellikler ve yöntemler devralmasını sağlayan bir mekanizmadır. Kod yeniden kullanımını destekler ve hiyerarşik bir yapıyı destekler.

Çok biçimlilik: Farklı sınıflardan nesnelerin ortak bir üst sınıfın nesneleri olarak ele alınabilmesi yeteneğidir. Dinamik yöntem bağlama sağlar ve esnek ve genişletilebilir kod destekler.

Soyutlama: Karmaşık gerçekliği, temel özellikler temelinde sınıflar modelleyerek basitleştirme. Gereksiz ayrıntıları gizler ve ilgili özelliklere odaklanır.


*/