using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingLinkedList
{
    class Program
    {

        static void Main(string[] args)
        {
            GenericsLinkedList<string> stringLinkedList = new GenericsLinkedList<string>();
            string firstString = "Black";
            string secondString = "White";
            string thirdString = "Yes";
            string fourthString = "No";

            stringLinkedList.AddHead(firstString);
            stringLinkedList.AddHead(secondString);
            stringLinkedList.AddHead(thirdString);
            stringLinkedList.AddHead(fourthString);
          
            foreach (string str in stringLinkedList)
            {
                Console.WriteLine(str);
            }

         GenericsLinkedList<int> integerLinkedList = new GenericsLinkedList<int>();
            int firstInteger = 1;
            int secondInteger = 2;
            int thirdInteger = 3;

            integerLinkedList.AddHead(firstInteger);
            integerLinkedList.AddHead(secondInteger);
            integerLinkedList.AddHead(thirdInteger);

            foreach (int number in integerLinkedList)
            {
                Console.WriteLine(number);
            }

            GenericsLinkedList<char> characterLinkedList = new GenericsLinkedList<char>();
            char firstCharacter = 'a';
            char secondCharacter = 'b';
            char thirdCharacter = 'c';

            characterLinkedList.AddHead(firstCharacter);
            characterLinkedList.AddHead(secondCharacter);
            characterLinkedList.AddHead(thirdCharacter);

            foreach (char character in characterLinkedList)
            {
                Console.WriteLine(character);
            }


            Console.ReadKey();


        }
    }


    // Generic Linked List
    class GenericsLinkedList<T>
    {
        class LinkedlistNode
        {
            private LinkedlistNode next;
            private T item;

            public LinkedlistNode(T t)
            {
                next = null;
                item = t;

            }
            public LinkedlistNode Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
            public T Item
            {
                get
                {
                    return item;
                }
                set
                {
                    item = value;
                }
            }
        }
        private LinkedlistNode head;
        public GenericsLinkedList()
        {
            head = null;
        }
        public void AddHead(T t)
        {
            LinkedlistNode node = new LinkedlistNode(t);
            node.Next = head;
            head = node;
        }
        public IEnumerator<T> GetEnumerator()
        {
            LinkedlistNode current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }

        }

    }
}
