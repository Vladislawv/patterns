using Builder.Builders;

var woodBuilder = new WoodHouseBuilder();

Console.WriteLine("Start building wood house...");

woodBuilder.BuildWalls();
woodBuilder.BuildDoors();

var result = woodBuilder
    .GetHouse()
    .Parts();

Console.WriteLine(result);