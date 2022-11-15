namespace Observer.Publishers;

public class SecondPublisher : Publisher
{
    private string _currentName = "Initial name";
    
    public void SetName(string name)
    {
        _currentName = name;
        Notify();
    }
}