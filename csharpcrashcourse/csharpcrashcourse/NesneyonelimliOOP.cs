using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcrashcourse
{
    internal class NesneyonelimliOOP
    {

        //CLASS:Sınıflar, OOP'de nesnelerin özelliklerini (alanlar) ve davranışlarını (metotlar) tanımlayan yapıdır. Örneğin, "Araba" sınıfı, renk ve hız gibi özelliklerle "HareketEt" gibi metotları içerebilir.
        //class Car
        //{
        //    public string Color { get; set; }
        //    public int Speed { get; set; }

        //    public void Accelerate()
        //    {
        //        Speed += 10;
        //    }
        //}

        //KAPSÜLLEME:Kapsülleme, bir nesnenin özelliklerini ve davranışlarını diğer nesnelerden gizleme işlemidir. Kapsülleme, nesnelerin daha tutarlı ve sağlam olmasını sağlar.

        //Kapsülleme, public, protected, private ve internal erişim belirleyicilerini kullanarak yapılır. public erişim belirleyicisi, bir özelliğin veya davranışın tüm koddan erişilebilir olduğunu belirtir. protected erişim belirleyicisi, bir özelliğin veya davranışın aynı sınıftan türetilen sınıflardan erişilebilir olduğunu belirtir. private erişim belirleyicisi, bir özelliğin veya davranışın sadece aynı sınıftan erişilebilir olduğunu belirtir. internal erişim belirleyicisi, bir özelliğin veya davranışın aynı assembly'den erişilebilir olduğunu belirtir.

        public class Person
        {
            private string Name { get; set; }
            private int Age { get; set; }
        }
        Static:Nesne örneği alınmadan ulaşabildiğimiz metot, field, sınıf...DEĞİŞTİRİLEMEZ
        public class Person
        {
            public static int StaticAge { get; set; }
            public static void StaticSayHi()
            {
                Console.WriteLine("Hi!");
            }
        }
        //INHERITANCE: Inheritance, bir sınıfın özelliklerini ve davranışlarını başka bir sınıfa aktarmasıdır.
        //public class SportsCar : Car
        //{
        //    public int Horsepower { get; set; }

        //    public void Accelerate()
        //    {
        //        // SportsCar'ın hızını Car'ın hızından 20 daha fazla artırır
        //        Speed += 10 + Horsepower;
        //    }
        //}
        //ENUM:C# programlama dilinde "enum" (enumeration), belirli bir veri türünü temsil eden ve genellikle sabit değerlerin sembolik adlarını içeren bir türdür.
        //enum DayOfWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
        //ABSTRACT:Bir abstract sınıfın önemli özelliği, doğrudan bir nesne örneği (instance) oluşturulamamasıdır. Yani abstract sınıflardan doğrudan nesne oluşturulamaz, ancak abstract sınıfları temel alarak türetilen somut sınıflar oluşturulabilir.
        //abstract class Shape
        //{
        //    public string Color { get; set; }

        //    public abstract double CalculateArea(); // Soyut metot
        //}
        //class Circle : Shape
        //{
        //    public double Radius { get; set; }

        //    public override double CalculateArea()
        //    {
        //        return Math.PI * Radius * Radius;
        //    }
        //}

        //class Rectangle : Shape
        //{
        //    public double Width { get; set; }
        //    public double Height { get; set; }

        //    public override double CalculateArea()
        //    {
        //        return Width * Height;
        //    }
        //}

        //INTERFACE:Interface, bir sınıfın sahip olması gereken özellikleri ve davranışlarını tanımlayan bir yapıdır. Interface'ler, nesneler oluşturmak için kullanılamaz. Interface'ler, inheritance ve polymorphism için kullanılı
        //public interface IAnimal
        //{
        //    void MakeSound();
        //    void Eat();
        //}
        //public class Dog : IAnimal
        //{
        //    public void MakeSound()
        //    {
        //        Console.WriteLine("Woof!");
        //    }

        //    public void Eat()
        //    {
        //        Console.WriteLine("I'm eating!");
        //    }
        //}






    }

}