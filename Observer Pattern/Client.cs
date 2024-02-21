using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class Client:ISubscriber
    {
        public List<Notification> Notifications { get; set; } = new List<Notification>();
        public string Username { get; set; }
        public Client(string username)
        {
            Username = username;
        }

        public void Update(Notification notification)
        {
            Notifications.Add(notification);
        }
        public void Display()
        {
            foreach (Notification notification in Notifications)
            {
                Console.WriteLine(notification.ToString());
            }
        }
    }
}
