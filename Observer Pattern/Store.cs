using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class Store
    {
        public List<string> Products { get; set; } = new List<string>();
        //               what product the subscriber is interested in 
        public Dictionary<string, List<ISubscriber>> Subscribers { get; set; } = new Dictionary<string, List<ISubscriber>>();
        public void AddProduct(string product)
        {
            Products.Add(product);
            Notify(product);
        }
        public void RemoveProduct(string product)
        {
            Products.Remove(product);
        }
        public void AddSubscriber(string subscriptionType, ISubscriber subscriber)
        {
            if(Subscribers.ContainsKey(subscriptionType)) 
                Subscribers[subscriptionType].Add(subscriber);
            else
                Subscribers.Add(subscriptionType,new List<ISubscriber> { subscriber });
        }
        public void RemoveSubscriber(string subscriptionType, ISubscriber subscriber)
        {
            if (Subscribers.ContainsKey(subscriptionType))
                Subscribers[subscriptionType].Remove(subscriber);
        }
        public void Notify(string subscriptionType)
        {
            if (Subscribers.ContainsKey(subscriptionType))
            {
                foreach (var subscriber in Subscribers[subscriptionType])
                {
                    subscriber.Update(new Notification
                    {
                        Date = DateTime.Now,
                        Message = $"{subscriptionType} is available now!"
                    });
                }
            }
        }
    }
}
