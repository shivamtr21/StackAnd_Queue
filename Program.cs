using static StackAndQueue.Class1;

namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Queue Program!");
            Console.WriteLine("#####################");
            Class1 Queue = new Class1();


            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);
            Queue.Dequeue();
            Queue.Display(); ;


        }
    }
}