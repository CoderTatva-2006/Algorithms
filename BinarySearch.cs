using System;
//
namespace BinarySearch{
    class binarySearch{
        public int search(int[] array, int query){
            // variables.
            int len = array.Length; // length of the array.
            int low = 0; // lower index of array under consideration.
            int high = len - 1; // upper index.
            int mid_index = 0; // index under consideration.
            
            if (len == 0){
                return -1; // if array does not have any elements.
            }
            //
            while (low <= high){
                mid_index = (low + high);

                //uncomment below to get debug prints.
                //Console.WriteLine($"{low} {high} {mid_index} ");

                if (array[mid_index] == query){
                    return mid_index; // if index has queried value.
                }
                if (array[mid_index] > query){ 
                    high = mid_index - 1; // discard upper half.
                } else { 
                    low = mid_index + 1; // discard lower half.
                }
            }
            return -1; // if not found.
        }
    }
}