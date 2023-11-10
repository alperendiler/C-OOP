using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.UnitPrice = 10;
product1.ProductName = "Kulaklık";
product1.UnitsInStock = 14;

Product product2 = new Product {Id=2, CategoryId =1, UnitPrice=4,ProductName="Bardak",UnitsInStock=5 };


ProductManager productManager = new ProductManager();
productManager.Add(product1);














