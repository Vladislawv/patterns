using Observer.Publishers;
using Observer.Subscribers;

Console.WriteLine("Start of program.");

IPublisher firstPublisher = new FirstPublisher();
IPublisher secondPublisher = new SecondPublisher();

Console.WriteLine("Notify users before subscribe: (nothing expected)");

firstPublisher.Notify();
secondPublisher.Notify();

Console.WriteLine("Subscribe different users to different publishers: (subscribe expected) \n");

ISubscriber firstSub = new FirstSubscriber();
ISubscriber secondSub = new SecondSubscriber();

firstPublisher.Subscribe(firstSub);
firstPublisher.Subscribe(secondSub);

secondPublisher.Subscribe(firstSub);
secondPublisher.Subscribe(secondSub);

Console.WriteLine("Notify users after subscribe: (all publishers notify expected) \n");

firstPublisher.Notify();
secondPublisher.Notify();

Console.WriteLine("Unsubscribe users from first publisher: (unsubscribe expected)");

firstPublisher.Unsubscribe(firstSub);
firstPublisher.Unsubscribe(secondSub);

Console.WriteLine("Notify users after unsubscribe from first publisher: (second publisher notify expected)");

firstPublisher.Notify();
secondPublisher.Notify();

Console.WriteLine("Change current state of second publisher object: (notify users of changes expected)");

var publisher = (SecondPublisher)secondPublisher;

publisher.SetName("I just set current state of publisher!");