using System.Runtime.CompilerServices;

namespace Observer_Pattern
{
    internal class Program
    {
        /*
        let's say i have a mobile store, and there are some people are interested in the new upcoming
        iphone, so they come to my store everyday and ask: do u have the new iphone?
        they do that everyday
        so why the waste of resources? 
        what about I have a list of ppl who're interested in the new iphone
        and when the new iphone is available in the store, I'll notify the list of ppl who are interested
        in it 
        now my store is called observable or publisher
        and the ppl who're interested in the new iphone are called observers or subscribers

        take a look : https://refactoring.guru/design-patterns/observer

        in this example there are some bad design choices that contradict with the single responsibility principle
        like in the store, he is dealing with 2 things : 
                                                        1. store logic (add/remove product)
                                                        2. observer pattern logic (add/remove/notify subscriber)
        you can deal with this easily but i made that example quickly so you can just understand the idea
        ------
        there're multiple ways of designing the observer pattern 
        my example is one of the ways, in head first design patterns book there is another way 
        but i don't like the example they introduced

         */
        static void Main(string[] args)
        {
            Store store = new Store();
            store.AddProduct("samsung");
            store.AddProduct("redmi");
            store.AddProduct("nothing phone");
            store.AddProduct("realme");
            Client client = new Client("omar");
            client.Display();
            store.AddSubscriber("iphone", client);
            Thread.Sleep(2000);
            store.AddProduct("iphone");
            client.Display();
        }
    }
}
