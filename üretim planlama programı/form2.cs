using System;
using System.Collections.Generic;

namespace CNCMetalProcessingFactory
{
    class Program
    {
        // Ürün sınıfı
        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Status { get; set; }
            public DateTime ProductionDate { get; set; }

            public Product(int id, string name, string status, DateTime productionDate)
            {
                Id = id;
                Name = name;
                Status = status;
                ProductionDate = productionDate;
            }

            // Ürünü ekrana yazdıran metod
            public void PrintProduct()
            {
                Console.WriteLine($"ID: {Id}, Name: {Name}, Status: {Status}, Production Date: {ProductionDate.ToShortDateString()}");
            }
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            // Menü döngüsü
            while (true)
            {
                Console.Clear();
                Console.WriteLine("CNC Metal İşleme Fabrikası - Ürün Takip Sistemi");
                Console.WriteLine("1. Ürün Listele");
                Console.WriteLine("2. Ürün Ekle");
                Console.WriteLine("3. Ürün Durumunu Güncelle");
                Console.WriteLine("4. Çıkış");
                Console.Write("Seçiminizi yapın: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ListProducts(products);
                        break;

                    case "2":
                        AddProduct(products);
                        break;

                    case "3":
                        UpdateProductStatus(products);
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }

        // Ürün listeleme
        static void ListProducts(List<Product> products)
        {
            Console.Clear();
            Console.WriteLine("Tüm Ürünler:");
            if (products.Count == 0)
            {
                Console.WriteLine("Hiç ürün eklenmemiş.");
            }
            else
            {
                foreach (var product in products)
                {
                    product.PrintProduct();
                }
            }
        }

        // Ürün ekleme
        static void AddProduct(List<Product> products)
        {
            Console.Clear();
            Console.Write("Ürün Adı: ");
            string name = Console.ReadLine();
            Console.Write("Ürün Durumu (Örnek: Üretimde, Tamamlandı): ");
            string status = Console.ReadLine();
            Console.Write("Üretim Tarihi (gg/aa/yyyy): ");
            DateTime productionDate;
            while (!DateTime.TryParse(Console.ReadLine(), out productionDate))
            {
                Console.WriteLine("Geçersiz tarih formatı. Lütfen tekrar deneyin.");
            }

            int id = products.Count + 1; // ID her yeni ürün için artacak
            products.Add(new Product(id, name, status, productionDate));

            Console.WriteLine("Ürün başarıyla eklendi!");
        }

        // Ürün durumunu güncelleme
        static void UpdateProductStatus(List<Product> products)
        {
            Console.Clear();
            Console.Write("Güncellemek istediğiniz ürün ID'sini girin: ");
            int id = int.Parse(Console.ReadLine());
            var product = products.Find(p => p.Id == id);

            if (product != null)
            {
                Console.Write("Yeni Durum: ");
                string newStatus = Console.ReadLine();
                product.Status = newStatus;
                Console.WriteLine("Ürün durumu başarıyla güncellendi!");
            }
            else
            {
                Console.WriteLine("Bu ID'ye sahip bir ürün bulunamadı.");
            }
        }
    }
}