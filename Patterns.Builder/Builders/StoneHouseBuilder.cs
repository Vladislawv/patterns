using Builder.Entities;

namespace Builder.Builders;

public class StoneHouseBuilder : IHouseBuilder
{
    private House _house = new();

    public StoneHouseBuilder()
    {
        Reset();
    }

    public void BuildWalls()
    {
        _house.Add("Stone walls");
    }

    public void BuildDoors()
    {
        _house.Add("Stone doors");
    }

    public void BuildWindows()
    {
        _house.Add("Stone windows");
    }

    public void BuildRoof()
    {
        _house.Add("Stone roof");
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