using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Please choose program number to execute");
            Console.WriteLine("1:LinkedList\n2:Stack\n3:Queue\n4:Exit\n5:Stack Using LinkedList\n6:BinarySearchTree\n7:SortedLinkedList\n8:HashTable");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                //case 1:
                //    Console.WriteLine("Builin");
                //    LinkedList<int> list = new LinkedList<int>();
                //    list.AddLast(10);
                //    list.AddLast(20);
                //    list.AddLast(30);
                //    break;

                //case 2:
                //    LinkedlistStack stack = new LinkedlistStack();
                //    stack.Push(70);
                //    stack.Push(30);
                //    stack.Push(56);
                //    stack.Display();
                //    // stack.Peek();
                //    // stack.Pop();
                //    Console.WriteLine("is stack empty? {0}", stack.isEmpty());
                //    stack.Display();
                //    break;
                //case 3:
                //    LinkedListQueue queue = new LinkedListQueue();
                //    queue.Enqueue(56);
                //    queue.Enqueue(30);
                //    queue.Enqueue(70);
                //    queue.Display();
                //    queue.Dequeue();
                //    queue.Display();
                //    break;

                //case 5:
                ////  LinkedlistStack customStack = new LinkedlistStack();
                // // customStack.PushByLinkedList(70);
                //  customStack.PushByLinkedList(30);
                //  customStack.PushByLinkedList(56);
                //  customStack.DisplayByLinkedList();
                //  break;
                //    default:
                //        break;
                //}
                case 8:
                    string paragraph = "Paranoids are not" +
                        "paranoid because they are paranoid but" +
                        "because they keep putting themselves" +
                        "deliberately into paranoid avoidable situations";
                    CountNumberOfOccurance(paragraph);
                    break;


                    Console.ReadLine();
            }
        }
        public static void CountNumberOfOccurance(string paragraph)
        {
            Hashtable<string, int> hashTable = new Hashtable<string, int>(6);
            string[] words = paragraph.Split(' ');
            foreach (string word in words)
            {
                if (hashTable.Exists(word.ToLower()))
                    hashTable.Add(word.ToLower(), hashTable.Get(word.ToLower()) + 1);
                else
                    hashTable.Add(word.ToLower(), 1);//to1
            }
            Console.WriteLine("Displaying after add operation");
            hashTable.Display();
            string s = "avoidable";
            hashTable.Remove(s);
            Console.WriteLine("After removed an item {0}", s);
            hashTable.Display();
            Console.ReadLine();

        }
    }
}
