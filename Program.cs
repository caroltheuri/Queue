using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        public static int[] que = new int[5];
        public static int rear = -1;
        public static int front = -1;
        static void Main(string[] args)
        {

            //Queue<string> qt = new Queue<string>();
            //qt.Enqueue("John");
            //qt.Enqueue("April");
            //qt.Enqueue("Jane");
            //qt.Enqueue("Sarah");
            //foreach (string name in qt)
            //{
            //    Console.WriteLine($"the names is{name}!");
            //}
            //Console.WriteLine("After dequeueing this is what happens:");
            //qt.Dequeue();
            //foreach (string st in qt)
            //{
            //    Console.WriteLine($"the names is{st}!");
            //}
            int ch = 0;
            int el = 0;
            bool check = false;
            do
            {
                Console.WriteLine("\n1.insert 2.delete 3.display 4.exit\nEnter ur choice: ");
                ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the element you want to insert");
                        el = Int32.Parse(Console.ReadLine());
                        insert(el);
                        break;
                    case 2:
                        delete();
                        break;
                    case 3:
                        display();
                        break;
                    case 4:
                        check = true;
                        break;

                }
            }
            while (!check);

        }
        //To insert to a queue increment the rear or entry point to make the other indexes greater than 0 to have elements
        public static void insert(int i)
        {
            if (front > 4)
            {
                Console.WriteLine("Queue is full cannot add any new elements");
            }
            que[++rear] = i;
            Console.WriteLine("Successfully inserted");
        }
        public static void delete()
        {
            //A queue is empty when the rear and front are equal . Therefore you cannot delete from an empty queue
            if (rear == front)
            {
                Console.WriteLine("There is nothing to be deleted");
            }

            //If the queue is not empty move the head forward because someone will have to leave so as to occupy that space.
            else
            {
                _ = que[++front];
                Console.WriteLine("Successfully deleted");
            }
            
        }
        public static void display()
        {
            foreach (int num in que)
            {
                Console.WriteLine($"Element is : {num}");
            }
        }

    }
}
