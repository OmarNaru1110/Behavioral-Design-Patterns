namespace State_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gate gate = new Gate();
            /*
                HOW THIS WILL WORK?
                will, u know who is the client?
                i guess the client will be that device that is attached to the gate
                that u can pay through, that client maybe can detect people around him
                it can detect whether someone is trying to enter or putting his card to pay,
                so it's like an event in my expectation
                when someone tries to enter the gate, the client detects that and then invoke gate.enter()
                I hope u know what i mean, we can try to imitate that scenario in the following code
             */

            ConsoleKeyInfo keyInfo;
            Console.WriteLine("Press 'p' to pay or Enter to enter the gate, any other key to exit.");
            do
            {
                keyInfo = Console.ReadKey(true); // true to not echo the pressed key

                if (keyInfo.Key == ConsoleKey.Enter)
                    gate.Enter();
                else if(keyInfo.Key == ConsoleKey.P)
                    gate.Pay();
                else
                {
                    Console.WriteLine("Exiting. You pressed a key other than 'p' or Enter.");
                    break;
                }
            } while (true);
        }
    }
}
