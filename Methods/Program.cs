

using Methods;

Product product1 = new Product();
product1.Id = 1;
product1.Name = "Elma";
product1.UnitPrice = 15;
product1.Explain = "Amasya Elması";

Product product2 = new Product();
product2.Id = 2;
product2.Name = "Karpuz";
product2.UnitPrice = 80;
product2.Explain = "Diyarbakır Karpuzu";

Product[] products = new Product[] { product1, product2 };

foreach (Product product in products)
{
    Console.WriteLine(product.Id);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.UnitPrice);
    Console.WriteLine(product.Explain);
    Console.WriteLine("---------------------");
}


Console.WriteLine("-------Methods------------");

BasketManager basketManager = new BasketManager();
basketManager.Add(product1);
basketManager.Add(product2);

basketManager.Add2("Armut", "Yeşil", 13,20);


