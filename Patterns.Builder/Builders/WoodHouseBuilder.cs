using Builder.Entities;

namespace Builder.Builders;

public class WoodHouseBuilder : IHouseBuilder
{
    private House _house = new();
    
    public WoodHouseBuilder()
    {
        Reset();
    }

    public void BuildWalls()
    {
        _house.Add("Wood walls");
    }

    public void BuildDoors()
    {
        _house.Add("Wood doors");
    }

    public void BuildWindows()
    {
        _house.Add("Wood windows");
    }

    public void BuildRoof()
    {
        _house.Add("Wood roof");
    }

    public House GetHouse()
    {
        var result = _house;
        
        Reset();

        return result;
    }
    
    private void Reset()
    {
        _house = new House();
    }
}