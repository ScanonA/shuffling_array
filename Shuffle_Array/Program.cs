using System;
using System.Linq;  

namespace Shuffle_Array{
    public class Program {
        private static void Main(string[] args){
            int[] unshuffled_array = Enumerable.Range(1,10000).ToArray();
            int [] shuffled_array = Shuffle_Array.ModernFisher_YatesAlgorithm.shuffle(unshuffled_array);
            print_arr(shuffled_array);
        }  

        /// summary:
        /// prints to console values of array in order of index
        /// 
        /// param name="array": an array of integers
        /// param name="array_length": array length
        ///
        /// returns: N/A
        private static void print_arr(int[] array){
            int array_length = array.Length;
            Console.Write("Shuffled Array: [");
            for(int i=0; i<array_length; i++){
                if(i!=array_length-1) {
                    Console.Write(array[i]+", ");
                }else Console.Write(array[i]);
            }
            Console.Write("]");
        }
    }   
}