

using OOP2;

IndividualCustomer customer1 =new IndividualCustomer();
customer1.CustomerId = "25616";
customer1.Name = "Alperen";
customer1.LastName = "Diler";
customer1.Id = 1;
customer1.TcNumber = "6141";


CorporateCustomer customer2 =new CorporateCustomer();
customer2.Id = 2;
customer2.CustomerId = "13";
customer2.CompanyName = "Diler Holding";
customer2.TaxNumber = "1651";




Customer customer3 =new CorporateCustomer();
Customer customer4 =new IndividualCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);
















