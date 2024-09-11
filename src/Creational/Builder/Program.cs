using Builder;

MealDirector mealDirector;

IMealBuilder vegetarianMealBuilder = new VegetarianMealBuilder();
mealDirector = new MealDirector(vegetarianMealBuilder);

mealDirector.Construct();
mealDirector.Show();

IMealBuilder nonVegetarianMealBuilder = new NonVegetarianMealBuilder();
mealDirector = new MealDirector(nonVegetarianMealBuilder);

mealDirector.Construct();
mealDirector.Show();

Console.ReadKey();