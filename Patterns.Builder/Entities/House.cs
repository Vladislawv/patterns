namespace Builder.Entities;

public class House
{
    private readonly List<object> _parts = new();

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public string Parts()
    {
        var result = _parts.Aggregate("", (current, part) => current + (part + ", "));

        result = result.Remove(result.Length - 2);

        return "House parts: " + result;
    }
}