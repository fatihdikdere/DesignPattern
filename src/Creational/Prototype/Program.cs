//Client

using Prototype;

var warriorPrototype = new Warrior("warrior1", "first warrrior");

var clonedWarrior1 = (Warrior)warriorPrototype.Clone();
clonedWarrior1.Name = "Warrior clone 1";
clonedWarrior1.Description = "first cloned warrior";

var clonedWarrior2 = (Warrior)warriorPrototype.Clone();
clonedWarrior2.Name = "Warrior clone 2";
clonedWarrior2.Description = "second cloned warrior";

Console.WriteLine(warriorPrototype.GetDetail());
Console.WriteLine(clonedWarrior1.GetDetail());
Console.WriteLine(clonedWarrior2.GetDetail());

Console.ReadKey();