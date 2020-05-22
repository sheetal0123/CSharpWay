using System;
using System.Collections;


namespace CSharpWay.com.collection
{

    class QueueEg
    {

        public static void Enque()
        {
            Queue que = new Queue();
            que.Enqueue("Welcome");
            que.Enqueue("To");
            que.Enqueue("C#");
            que.Enqueue(10.5f);
            que.Enqueue(100);

            foreach (var item in que)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Initial Counts : {0}", que.Count);


            while (que.Count > 0)
            {
                que.Dequeue();
            }

            Console.WriteLine("After Counts : {0}", que.Count);


            Console.WriteLine("======= * ======= * ======= * =======");

        }



        public static void main(string[] args)
        {
            Enque();
        }

    }

}
