using Facade;

var homeAutomationSystem = new HomeAutomationSystem (new GraphicEngine(), new HeatingEngine (), new SecurityEngine());
var result = homeAutomationSystem.IsHomeAbleToBeBuilt();
var resultText = result
    ? "Home is able to be built"
    : "Home is not able to be built";

Console.WriteLine(resultText);
Console.ReadKey();