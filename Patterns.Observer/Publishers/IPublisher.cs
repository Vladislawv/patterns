using Observer.Subscribers;

namespace Observer.Publishers;

public interface IPublisher
{
    public void Notify();
    public void Subscribe(ISubscriber subscriber);
    public void Unsubscribe(ISubscriber subscriber);
}