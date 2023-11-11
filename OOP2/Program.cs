


using OOP2;

IndividualCustomer customer1  = new IndividualCustomer();

customer1.Id = 1;
customer1.CustomerNumber = "123";
customer1.IdNo = "123456";
customer1.Name = "Ali";
customer1.LastName = "Karakoç";


CorporateCustomer customer2 = new CorporateCustomer();
 
customer2.Id = 2;
customer2.CustomerNumber = "54321";
customer2.CompanyName = "Kodlama";
customer2.TaxNo = "78965";


Customer customer3 = new IndividualCustomer();
Customer customer4 = new CorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);

