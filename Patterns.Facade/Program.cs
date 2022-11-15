using Patterns.Facade;
using Patterns.Facade.SubSystem;

var myFile = new MyFile("D:\\Programming\\Projects\\Patterns\\Patterns.Facade\\Repository\\test.txt");
var myArray = new MyArray();

var myFacade = new MyFacade(myFile, myArray);

var linesCount = await myFacade.GetLinesCountFromFileAsync();

Console.WriteLine($"Lines in file is: {linesCount}");