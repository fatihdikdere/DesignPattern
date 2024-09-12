using State;

var trafficLight = new TrafficLightContext();
var count = new Random().Next(70);

for (var i = 0; i < count; i++)
{
    trafficLight.ChangeLight();
}

Console.ReadKey();