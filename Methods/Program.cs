using Methods;


Product product1 = new Product();

product1.Name = "Ayva";
product1.Description = "Çekirdekli"; ;
product1.Price = 100;


Product product2 = new Product();


product2.Name = "Kavun";
product2.Description = "Manisa kavunu"; ;
product2.Price = 20;

Product[] products = new Product[] { product1, product2 };

foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Description);
    Console.WriteLine(product.Price);
    Console.WriteLine("-------------------");

}

Console.WriteLine("Metotlar");
Console.WriteLine("-------------------");
//insatance - örnek


//Encapsulation
HamperManager hamperManager = new HamperManager();
hamperManager.Add(products[0]);
hamperManager.Add(product1);
hamperManager.Add(product2);

hamperManager.Add2("Armut ","Sarı ", 12,2);
hamperManager.Add2("Elma ", "Yeşil Elma", 2,5);
hamperManager.Add2("Karpuz ", "Diyarbakır Karpuzu ", 124,8);

hamperManager.Delete();



