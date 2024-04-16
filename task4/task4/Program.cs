using System;
namespace EventHandling
{
    public delegate void EventHandler();
    public class EventManager
    {
        public event EventHandler? SomeoneSaidHello;
        public void AddEventHandler()
        {
            SomeoneSaidHello += SomeoneSaidHelloHandler;
        }
        public void RemoveEventHandler()
        {
            SomeoneSaidHello -= SomeoneSaidHelloHandler;
        }
        public void RaiseTheEvent()
        {
            if (SomeoneSaidHello != null)
                SomeoneSaidHello();
        }
        public void SomeoneSaidHelloHandler()
        {
            Console.WriteLine("hello there (:");
        }
    }
    class Main_class
    {
        static void Main(string[] args)
        {
            EventManager manager = new EventManager();
            Console.Write("say hello to the program:");
            var phrase = Console.ReadLine();
            if (phrase == "hello")
            {
                manager.AddEventHandler();
                manager.RaiseTheEvent();
            }
            manager.RemoveEventHandler();
        }
    }
}
