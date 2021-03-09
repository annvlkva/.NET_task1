using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string> {"one", "two", "three", "four"};
            linkedList.Show();
            linkedList.Remove("four");
            linkedList.Show();
            linkedList.Reverse();
            linkedList.Show();
        }
    }
}