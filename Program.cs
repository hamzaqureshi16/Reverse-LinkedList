using System.Net.NetworkInformation;

namespace ReverseLinkedList
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            
            for(int i = 0; i <= 10; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("Original List");
            list.Print();
            list = list.reverse();
            
            Console.WriteLine("\nReversed List");
            list.Print();
        }
    }
}