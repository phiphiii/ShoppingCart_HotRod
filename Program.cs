using System;
namespace ShoppingCart
{
    class Program
    {
        List<Product> Products = new List<Product> { };
        //new Product(){ProductId = 1, ProductModel = "CD-60 V3", ProductBrand = "Fender", ProductPrice = 650.0}
        static void Main(string[] args)
        {
            try
            {
                Menu();
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nPodano nie poprawną opcję\n");
            }
        }
        static void Menu()
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
                        Console.WriteLine("Lista produktów\n");
                        Console.WriteLine("Podaj ID by dodać produkt");
                        break;
                }
            } while (opcja != 6) ;
            

        }
    }
    


}