using Observer.Subscribers;

namespace Observer.Publishers;

public class Publisher : IPublisher
{
    private readonly List<ISubscriber> _subscribers = new();

    public void Notify()
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Notify(this);
        }
    }
    
    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
        Console.WriteLine($"{subscriber.GetType().Name} subscribed to me({GetType().Name}). \n");
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
        Console.WriteLine($"{subscriber.GetType().Name} unsubscribed from me({GetType().Name}). \n");
    }
}