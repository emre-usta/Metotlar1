using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Out parametreler

            string sayi = "9999";

            bool sonuc = int.TryParse(sayi, out int outsayi);

            if(sonuc)
            {
                Console.WriteLine("Dönüşüm başarılı!");
                Console.WriteLine(outsayi);
            }
            else
            {
                Console.WriteLine("Dönüşüm başarısız!");
            }
            Console.WriteLine("------------------------");

            Metotlar instance = new Metotlar();
            instance.Topla(5,35, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            // Metot Overloading

            int ifade = 9999;
            
            instance.Yazdir(ifade);
            instance.Yazdir("Emre", "Usta");

            // Metot imzası
            // metotAdı + Parametre sayısı + parametre
            

        }   
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void Yazdir(string veri)
        {
            Console.WriteLine(veri);
        }
                                            // overload ettik hem srting hem int tipinde veri alabiliyoruz. Bu yüzden yukarıda integerı stringe dönüştürmemize gerek kalmadı.
        public void Yazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void Yazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}