namespace Patterns.Facade.SubSystem;

public class MyFile
{
    private readonly string _path;

    public MyFile(string path)
    {
        _path = path;
    }

    public async Task<string[]> ReadAllLinesAsync()
    {
        return await File.ReadAllLinesAsync(_path);
    }
}