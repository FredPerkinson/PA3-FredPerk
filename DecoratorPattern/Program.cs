using PizzaDecorator;

Pizza pizza = new Pizza();
pizza = new Cheese(pizza);
pizza = new Cheese(pizza);
pizza.SetSize("Small");
System.Console.WriteLine(pizza.GetDescription() + " and cost is " + pizza.Cost());