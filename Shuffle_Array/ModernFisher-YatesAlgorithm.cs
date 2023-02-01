namespace Shuffle_Array {
    public class ModernFisher_YatesAlgorithm {
        
        /// summary:
        /// If the array length is shuffle-able, the method returns the result of the "modern_fisher_yates_shuffle" 
        /// function applied to the input array. Otherwise, the original array is returned without any changes.
        ///
        /// param name="array_length": array length
        ///
        /// returns: Shuffled or unshuffled array of integers
        public static T[] shuffle<T>(T[] array){
            int array_length = array.Length;
            if(isShuffleble(array_length)){
                return modern_fisher_yates_shuffle(array, array_length);
            } else return array;
        }

        /// summary:
        /// Checks to see if array length is greater than 1 as
        /// shuffling lengths 0,1 is impossible.
        ///
        /// param name="array_length": array length
        ///
        /// returns: boolean
        private static bool isShuffleble(int array_length){
            if(array_length > 1) return true;
            else return false;
        }
        
        /// summary:
        /// Shuffles a list of integers using the modern Fisher-Yates algorithm.
        /// 
        /// param name="array": an array of integers
        /// param name="array_length": array length
        ///
        /// returns: Shuffled array of integers
        private static T[] modern_fisher_yates_shuffle<T>(T[] array, int array_length) {
            Random rand = new Random();
            for(int i=0; i<array_length; i++) {
                int end_index_ofUnshuffled = (array_length-1) - i;
                int random_index = rand.Next(end_index_ofUnshuffled);
                T temp = array[random_index];
                array[random_index] = array[end_index_ofUnshuffled];
                array[end_index_ofUnshuffled] = temp;
            }
            return array;
        }
    }
}