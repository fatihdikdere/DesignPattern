using Command;

var mySystem = new MySystem();

var startSystemCommand1 = new StartSystemCommand(mySystem, "Windows11");
var startSystemCommand2 = new StartSystemCommand(mySystem, "Linux");
var startSystemCommand3 = new StartSystemCommand(mySystem, "Ubuntu");

var stopSystemCommand1 = new StopSystemCommand(mySystem, "Windows11");
var stopSystemCommand2 = new StopSystemCommand(mySystem, "Linux");
var stopSystemCommand3 = new StopSystemCommand(mySystem, "Ubuntu");

var commandInvoker = new CommandInvoker();   

commandInvoker.AddCommand(startSystemCommand1);
commandInvoker.AddCommand(startSystemCommand3);
commandInvoker.AddCommand(startSystemCommand2);
commandInvoker.AddCommand(stopSystemCommand3);

commandInvoker.ExecuteCommands();

Console.WriteLine(Environment.NewLine);

commandInvoker.UndoLastCommand();

Console.ReadKey();