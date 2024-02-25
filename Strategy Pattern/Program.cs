namespace Strategy_Pattern
{
    internal class Program
    {
        /*
         take a look at the diagram 
        and if u still confused 
        u can watch this video: https://www.youtube.com/watch?v=v9ejT8FO-7I&t=2s

        let's say if we have small list we do bubble sort 
        if the list was huge we do selection sort
         */
        static void Main(string[] args)
        {
            DataStructure hugeList = new(new List<int> { 10, 5, 6, 3, 2, 1, 8, 9, 0 }, new SelectionSort());
            hugeList.Print();
            hugeList.Sort();
            hugeList.Print();
        
        }
    }
}
