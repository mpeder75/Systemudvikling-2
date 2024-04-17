

using Session_18___Strategy_Eksempel_1;
using Session_18___Strategy_Eksempel_1.ConcreteStrategy;

ShoppingCart cart = new ShoppingCart();

Item item1 = new Item("1234", 10.0);
Item item2 = new Item("990000098", 10.0);

cart.AddItem(item1);
cart.AddItem(item2);

// Her vil vil betale med Paypal
cart.Pay(new PaypalStrategy ( "bob@gmail.com", "2345"));

// Her vil vi betale med vores Credit Card
cart.Pay(new CreditCardStrategy("Bob", "987654", 666, new DateTime(2030, 11, 11)));
