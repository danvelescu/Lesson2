using Lesson2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class MainStore
    {
        List<Product>  products = new List<Product>();
        public string AddProduct() {
            Product product = new Product();
            product.Name = "Lays";
            products.Add(product);
            return "Product with product name:"+products[0].Name +" And id: "+product.Id+ " has been saved";
        }

        public static void Main() {
            MainStore mainStore = new MainStore();
            Console.WriteLine(mainStore.AddProduct());
            Console.WriteLine(mainStore.AddProduct());
        }
    }
}
