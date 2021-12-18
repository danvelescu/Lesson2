using Lesson2.Model;

namespace Lesson2
{
    public class MainStore
    {
        UiProvider uiProvider = new UiProvider();
        List<Product>  products = new List<Product>();

        public static void Main() {
            MainStore mainStore = new MainStore();


            var menuValue = mainStore.uiProvider.PrintMainMenu();



            switch (menuValue)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    mainStore.products.Add(mainStore.uiProvider.AddProductMenu());
                    break;
            }


            foreach (var product in mainStore.products) {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
