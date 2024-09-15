using Flyweight;
using File = Flyweight.File;

var iconFactory = new IconFactory();

var file1 = new File("fatihd.txt", iconFactory.GetIcon("txt"));
var file2 = new File("fatihd.png", iconFactory.GetIcon("png"));

file1.DisplayIcon();
file2.DisplayIcon();

Console.ReadKey();