using Lesson2.Model;

namespace Lesson2
{
    public class UiProvider
    {
        public string PrintMainMenu()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("|Hello user                                                                         |");
            Console.WriteLine("|Please type number of item in menu and press enter                                 |");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("1.List of products");
            Console.WriteLine("--------------------");
            Console.WriteLine("2.Buy one product");
            Console.WriteLine("--------------------");
            Console.WriteLine("3.Finish buying");
            Console.WriteLine("--------------------");
            Console.WriteLine("4.Add Product");
            Console.WriteLine("--------------------");
            var value = Console.ReadLine();
             
            if (!(value != "3" || value != "2" || value != "1" || value != "4"))
            {
                Console.Clear();
                Console.WriteLine("Invalid menu item please chouse another");
                PrintMainMenu();
            }
            return value;
        }


        public Product AddProductMenu() {
            Product product = new Product();
          
            Console.WriteLine("Type product name:\n");
            var name = Console.ReadLine();

            Console.WriteLine("Type product description:\n");
            var description = Console.ReadLine();

            Console.WriteLine("Type product price:\n");
            var price = Console.ReadLine();

            product.Price = Convert.ToDecimal(price);
            product.Description = description;
            product.Name = name;

            Console.WriteLine("Type Of product:");
            Console.WriteLine("1 "+TypeOfProduct.Construction_materials.ToString());
            Console.WriteLine("2 "+TypeOfProduct.Fabric.ToString());
            Console.WriteLine("3 "+TypeOfProduct.Food.ToString());
            Console.WriteLine("4 "+TypeOfProduct.For_home.ToString());
            var typeOfProduct = Console.ReadLine();

            switch (typeOfProduct) {
                case "1":
                    product.TypeOfProduct = TypeOfProduct.Construction_materials;
                    break;
                case "2":
                    product.TypeOfProduct = TypeOfProduct.Construction_materials;
                    break;
                case "3":
                    product.TypeOfProduct = TypeOfProduct.Construction_materials;
                    break;
                case "4":
                    product.TypeOfProduct = TypeOfProduct.Construction_materials;
                    break;
                default:
                    product.TypeOfProduct = TypeOfProduct.Other;
                    break;
            }

            return product;
        }
    }

}

