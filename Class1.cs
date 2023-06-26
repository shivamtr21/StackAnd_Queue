using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Class1
    {

        public Node top;
        public void StackWithLinkedList()
        {
            this.top = null;
        }

        public void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }


        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        //Peek top most element
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine($"{this.top.data} is the top of the stack ");
        }

        //Pop remove element
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty,Deletion is not possible");
                return;
            }
            Console.WriteLine($"Value poped is {this.top.data}");
            this.top = this.top.next;
        }

        // Check Empty
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }



    }
}
