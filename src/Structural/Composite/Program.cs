using Directory = Composite.Directory;
using File = Composite.File;

var file1 = new File("file1.txt", 500);
var file2 = new File("file2.txt", 1500);
var file3 = new File("file3.txt", 1000);

var directory1 = new Directory("directory1");
directory1.AddItem(file1);
directory1.AddItem(file3);

var directory2 = new Directory("directory2");
directory2.AddItem(file2);

var rootDirectory = new Directory("root");
rootDirectory.AddItem(directory1);
rootDirectory.AddItem(directory2);

Console.WriteLine(rootDirectory.ToString());
Console.WriteLine($"Total size: {rootDirectory.GetSize()}");

Console.ReadKey();