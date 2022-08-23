using System;
using BinarySearch;
//
namespace Algorithms{
	class Program{
	    static void Main(){
            new Program().testBinarySearch();
	    }

        void testBinarySearch(){
            int itemToSearch = 7;
            int[] array = {1,7,11,12,13,15,32,52};
            Console.Write($"Searching for {itemToSearch} in [");
            foreach (var item in array)
            {
                Console.Write($" {item} ");
            }
            Console.Write("]");
            Console.WriteLine();
            int index = new binarySearch().search(array,itemToSearch);
            Console.WriteLine((index != -1)?$"The Item is at index {index}": $"Item not found.");

        }
	}
}