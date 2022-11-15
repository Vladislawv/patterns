using Observer.Publishers;

namespace Observer.Subscribers;

public class Subscriber : ISubscriber
{
    public void Notify(IPublisher publisher)
    {
        Console.WriteLine($"My name is: {GetType().Name}");
        Console.WriteLine($"I just take notification from {publisher.GetType().Name} ! \n");
    }
}