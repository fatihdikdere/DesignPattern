using Observer;

var stock = new Stock();
var investor1 = new Investor("fatih");
var investor2 = new Investor("d");

stock.Attach(investor1);
stock.Attach(investor2);

stock.Price = 70M;

Console.WriteLine();

stock.Price = 34M;

Console.WriteLine();

stock.Detach(investor1);

stock.Price = 0M;

Console.WriteLine();

stock.Detach(investor2);

stock.Price = 1M;

Console.ReadKey();