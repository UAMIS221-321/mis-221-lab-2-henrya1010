
// intialize  variables
int numberOfSandwiches = 0;
int numberOfToppings = 0;
int orderCost = 0;
double tip = 0;
double totalSandwichCost = 0;
double totalToppingCost = 0;
double baseCost = 0;

const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

// prompt user for number of sandwiches
System.Console.WriteLine("How many sandwiches?");
numberOfSandwiches = int.Parse(Console.ReadLine());
System.Console.WriteLine("Sandwiches " +numberOfSandwiches);
System.Console.WriteLine("How many toppings?");
numberOfToppings = int.Parse(Console.ReadLine());
System.Console.WriteLine("numberOfToppings is " + numberOfToppings);
System.Console.WriteLine("How much do you want to tip?");
tip = int.Parse(Console.ReadLine());

totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost;
orderCost = (int)(tip + (baseCost * (1-DISCOUNT_AMOUNT)));


System.Console.WriteLine("totalSandwichCost is " + totalSandwichCost);
System.Console.WriteLine("totalToppingCost is " + totalToppingCost);
System.Console.WriteLine("Total tip is " + tip);
System.Console.WriteLine("orderCost is " + orderCost);