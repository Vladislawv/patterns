using Observer.Publishers;

namespace Observer.Subscribers;

public interface ISubscriber
{
    public void Notify(IPublisher publisher);
}