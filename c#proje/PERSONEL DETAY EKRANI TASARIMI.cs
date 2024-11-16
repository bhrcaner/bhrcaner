using System;

namespace BasicMathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoş geldiniz! İki sayı ile toplama işlemi yapacağız.");

            // Kullanıcıdan birinci sayıyı al
            Console.Write("Birinci sayıyı girin: ");
            string input1 = Console.ReadLine();
            if (!double.TryParse(input1, out double sayi1))
            {
                Console.WriteLine("Geçerli bir sayı giriniz!");
                return;
            }

            // Kullanıcıdan ikinci sayıyı al
            Console.Write("İkinci sayıyı girin: ");
            string input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double sayi2))
            {
                Console.WriteLine("Geçerli bir sayı giriniz!");
                return;
            }

            // Toplama işlemi
            double sonuc = sayi1 + sayi2;

            // Sonucu ekrana yazdır
            Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");

            Console.WriteLine("Uygulama sonlandı. Çıkmak için bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}