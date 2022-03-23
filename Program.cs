using System;
namespace ShoppingCart
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Product> Products = new List<Product> { };
            Products.Add(new Product(1,"CD-60 V3","Fender",650.0));
            Products.Add(new Product(2, "GD10-NS", "TAKAMINE", 999.0));
            Products.Add(new Product(3, "PLAYER PLUS STRATOCASTER HSS PF BLB", "Fender",4999.0));
            Products.Add(new Product(4, "EC-256 SW", "LTD",650.0));
            Products.Add(new Product(5, "SLG200N SILENT GUITAR", "YAMAHA", 3499.0));
            try
            {
                Menu(Products);
                
            }
            catch (FormatException)
            {
                Console.WriteLine("\nPodano nie poprawną opcję\n");
            }
        }
        static void Menu(List<Product> Products)
        {
            int opcja = 0;
            do { 
                Console.WriteLine("Witamy w koszyki sklepu HotRod!");
                Console.WriteLine("1. Wyświetl zawatrość koszyka\n2. Dodaj produkt \n3. Usuń produkt\n4. Kup\n5. Zasil konto\n6. Wyłącz");
                opcja = Convert.ToInt32(Console.ReadLine());
                if(opcja > 6 || opcja < 1)
                {
                    Console.WriteLine("\nPodano nie poprawną opcję\n");
                }
                switch (opcja)
                {
                    case 1:
                        Console.WriteLine("Twoj koszyk: \n");
                        break;
                    case 2:
                        try
                        {
                            Products.ShowAll(Products);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nPodano nie poprawną opcję\n");
                        }
                        break;
                }
            } while (opcja != 6) ;
            

        }
        
    }
    


}