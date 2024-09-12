using TemplateMethod;

var coffee = new Coffee();
coffee.PrepareRecipe();

Console.WriteLine();

var tea = new Tea();
tea.PrepareRecipe();

Console.ReadKey();