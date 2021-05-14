using System;

namespace Codecamp_Priority_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and populate the queue
            PriorityObject test = new PriorityObject { name = "test", priority = 4 };
            PriorityQueue queue = new PriorityQueue();
            queue.list.Add(new PriorityObject { name = "chair", priority = 3 });
            queue.list.Add(new PriorityObject { name = "dog", priority = 2 });
            queue.list.Add(new PriorityObject { name = "cat", priority = 1 });
            queue.list.Add(new PriorityObject { name = "spoon", priority = 5 });
            queue.list.Add(new PriorityObject { name = "table", priority = 4 });

            //insert the test object into the queue
            queue.Enqueue(test);

            foreach (PriorityObject n in queue.list)
            {
                Console.WriteLine(n.name + " " + n.priority);
            }

            //remove the test object from the queue
            queue.Dequeue(test);

            Console.WriteLine("The front is " + queue.Front().name + " " + queue.Front().priority);

            foreach (PriorityObject n in queue.list)
            {
                Console.WriteLine(n.name + " " + n.priority);
            }

            Console.ReadLine();
        }
    }
}
