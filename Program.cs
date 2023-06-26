using static StackAndQueue.Class1;

namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Queue Program!");
            Console.WriteLine("#####################");
            Class1 obj = new Class1();
            obj.push(70);
            obj.push(30);
            obj.push(56);

            obj.Peek();
            Console.WriteLine("After pop operation:");
            obj.Pop();
            obj.IsEmpty();

            obj.Display();



        }
    }
}