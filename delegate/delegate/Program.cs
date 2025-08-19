using System;


public delegate void Notifier();

public class NotificationSystem
{
   
    public static void SendEmail()
    {
        Console.WriteLine("Email sent successfully.");
    }

    public static void SendSMS()
    {
        Console.WriteLine("SMS sent successfully.");
    }

    public static void SendPush()
    {
        Console.WriteLine("Push notification sent successfully.");
    }

   
    public static void NotifyAll(Notifier notifier)
    {
        if (notifier != null)
        {
            notifier(); // Invoke the delegate
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
       
        Notifier notifier = new Notifier(NotificationSystem.SendEmail);
        notifier += NotificationSystem.SendSMS;
        notifier += NotificationSystem.SendPush;

        
        Console.WriteLine("Sending all notifications:");
        NotificationSystem.NotifyAll(notifier);
    }
}
