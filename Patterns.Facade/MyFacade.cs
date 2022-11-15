using Patterns.Facade.SubSystem;

namespace Patterns.Facade;

public class MyFacade
{
    private readonly MyFile _file;
    private readonly MyArray _array;

    public MyFacade(MyFile file, MyArray array)
    {
        _file = file;
        _array = array;
    }

    public async Task<int> GetLinesCountFromFileAsync()
    {
        var array = await _file.ReadAllLinesAsync();

        return _array.GetLinesCount(array);
    }
}