namespace StackAndQueues_244
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues Data Structure Program");


            StackOperationUsingLinkedList stackOperation = new StackOperationUsingLinkedList();

            //stackOperation.Push(70);
            //stackOperation.Push(30);
            //stackOperation.Push(56);
            //stackOperation.IsEmpty();
            //stackOperation.Display();

            QueuesOperationUsingLinkedList queueOperation = new QueuesOperationUsingLinkedList();
            queueOperation.Enqueue(56);
            queueOperation.Enqueue(30);
            queueOperation.Enqueue(70);
            queueOperation.DisplayQueue();



        }
    }
}
