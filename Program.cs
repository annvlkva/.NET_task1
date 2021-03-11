using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            /*
            LinkedList<string> linkedList = new LinkedList<string> {"one", "two", "three", "four"};
            linkedList.Show();
            linkedList.Remove("four");
            linkedList.Show();
            linkedList.Reverse();
            linkedList.Show();
            */
            
            //2
            /*
            var binaryTree = new BinaryTree<int>();

            binaryTree.Add(8);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(1);
            binaryTree.Add(6);
            binaryTree.Add(4);
            binaryTree.Add(7);
            binaryTree.Add(14);
            binaryTree.Add(16);

            binaryTree.PrintTree();

            Console.WriteLine(new string('-', 40));
            binaryTree.Remove(3);
            binaryTree.PrintTree();

            Console.WriteLine(new string('-', 40));
            binaryTree.Remove(8);
            binaryTree.PrintTree();
            */
            
            // 3
            
            int[] array = {4, 6, 1, 5, 3, 2 };
            for(int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            var newArray = Sort.InsertionSort(array); 
            for(int i = 0; i < newArray.Length; i++)
                Console.Write(newArray[i] + " ");
        }
    }
}