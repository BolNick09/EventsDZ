namespace EventsDZ
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            EventPublisher publisher1 = new EventPublisher("Объект 1");
            EventPublisher publisher2 = new EventPublisher("Объект 2");

            EventHandler handler = new EventHandler();

            publisher1.MyEvent += handler.HandleEvent;
            publisher2.MyEvent += handler.HandleEvent;

            publisher1.RaiseEvent();    //Объект1
            publisher2.RaiseEvent();    //Объект2


            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Task2");
            EnterName enterName = new EnterName();
            enterName.ev_BannedUser += WarningAlarm;
            enterName.User();
            Console.ReadKey();
        }

        static void WarningAlarm(object sender, BannedUsersEventArgs e)
        {
            Console.WriteLine("{0} banned user found. Ask admin", e.Name);
            Console.WriteLine("Warning");
            Console.WriteLine("Press Ctrl + C to stop");

            //for (; ; )
            //{
            //    Console.Beep();
                
            //}
            
        }
    }
}
