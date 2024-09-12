using Memento;

var game = new Game(100, 0);
var gameSaveManager = new GameSaveManager();

Console.WriteLine(game.ToString());

game.SetHealth(80);
game.SetPosition(5);
game.AddToInventory("sword");

gameSaveManager.SaveGame(game);

game.SetHealth(90);
game.SetPosition(1);
game.AddToInventory("shield");

Console.WriteLine(game.ToString());

gameSaveManager.LoadLastSave(game);

Console.WriteLine(game.ToString());

Console.ReadKey();