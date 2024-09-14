using Decorator;

INotifier notifier = new EmailNotifier();

notifier = new SmsNotifier(notifier);
notifier = new PushNotifier(notifier);

notifier.Send("fatihd");

Console.ReadKey();