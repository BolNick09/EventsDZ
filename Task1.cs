using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDZ
{
    public class EventPublisher
    {
        public event EventHandler<string> MyEvent;

        private string name;

        public EventPublisher(string name)
        {
            this.name = name;
        }

        public void RaiseEvent()
        {       
            MyEvent?.Invoke(this, name);
        }
    }

    public class EventHandler
    {
        public void HandleEvent(object sender, string name)
        {
            Console.WriteLine($"Событие сгенерировано объектом {name}");
        }
    }
}
