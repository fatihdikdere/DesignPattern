using Singleton;

var instance = SingletonProvider<SampleClass>.Instance;

Console.WriteLine($"Id: {instance.Id}");
Console.WriteLine($"FullName: {instance.FullName}");

Console.ReadKey();