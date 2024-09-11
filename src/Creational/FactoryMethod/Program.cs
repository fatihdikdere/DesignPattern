using FactoryMethod;

var partTimeEmployee = new PartTimeEmployee();
var partTimeSalary = partTimeEmployee.CalculateSalary(10);

Console.WriteLine($"Part time salary: {partTimeSalary}");

var fullTimeEmployee = new FullTimeEmployee();
var fullTimeSalary = fullTimeEmployee.CalculateSalary(10);

Console.WriteLine($"Full time salary: {fullTimeSalary}");

Console.ReadKey();