using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductModel { get; set; }
        public string ProductBrand { get; set; }
        public double ProductPrice { get; set; }
        public Product(int ProductId, string ProductModel,string ProductBrand,double ProductPrice)
        {
            this.ProductId = ProductId;
            this.ProductModel = ProductModel;
            this.ProductBrand = ProductBrand;
            this.ProductPrice = ProductPrice;
        }
        public string Wyswietl()
        {
            return ProductId + ". " + ProductModel + " - " + ProductBrand + " | " + ProductPrice + "zł";
        }
        public string ShowAll(List<Product> Products)
        {
            string wynik = "";
            foreach (var key in Products)
            {
                wynik = key.Wyswietl()+"\n";
            }
            return wynik;
        }
        
        public int AddProduct(List<Product> Products)
        {
            Console.WriteLine("Lista produktów: \n");

            foreach (var key in Products)
            {
                Console.Write(key.Wyswietl() + "\n");
            }
            Console.Write("\n");
            Console.Write("Podaj ID by dodać produkt: ");
            int selctedId = 0;
            do
            {
                selctedId = Convert.ToInt32(Console.ReadLine());
                if (selctedId < 1 || selctedId > 5)
                {
                    Console.Write("Proszę podać jedno z podanych ID: ");
                }
            } while (selctedId < 0 || selctedId > 6);
            Console.WriteLine("");
            return selctedId;
        }
        
    }
}
