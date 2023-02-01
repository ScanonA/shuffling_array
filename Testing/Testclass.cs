using Xunit;
using System;
using System.Linq;  
using System.Collections.Generic;
using Shuffle_Array;

public class TestClass {
    
    [Fact] //Testing if array has been shuffled
    public void correctShuffle(){
        IEnumerable<int> unshuffled = Enumerable.Range(1, 10000);
        int[] unshuffled_array = unshuffled.ToArray();
        int[] original_array = unshuffled.ToArray();
        int[] shuffled_array = Shuffle_Array.ModernFisher_YatesAlgorithm.shuffle(unshuffled_array);

        Assert.NotEqual(original_array, shuffled_array);
    }

    [Fact] //Testing if Shuffled array has the correct range
    public void correctRange(){
        int[] unshuffled_array = Enumerable.Range(1, 10000).ToArray();
        int[] shuffled_array = Shuffle_Array.ModernFisher_YatesAlgorithm.shuffle(unshuffled_array);

        bool correctRange = shuffled_array.All((value) => value >= 1 && value <= 10000);
        Assert.True(correctRange);
    }

    [Fact] //Testing if Length of Shuffled array is the same as the original array
    public void correctLength(){
        IEnumerable<int> unshuffled = Enumerable.Range(1, 10000);
        int[] unshuffled_array = unshuffled.ToArray();
        int[] original_array = unshuffled.ToArray();
        int[] shuffled_array = Shuffle_Array.ModernFisher_YatesAlgorithm.shuffle(unshuffled_array);

        Assert.Equal(original_array.Length, shuffled_array.Length);
    }

    [Fact] //Testing if an empty array is passed, empty array is returned
    public void emptyArray(){
        int[] unshuffled_array = {};
        int[] shuffled_array = Shuffle_Array.ModernFisher_YatesAlgorithm.shuffle(unshuffled_array);

        Assert.Equal(new int[0], shuffled_array);
    }

    [Fact] //Testing if there are any duplicate elements in array
    public void duplicateElements(){
        int[] unshuffled_array = Enumerable.Range(1, 100).ToArray();
        int[] shuffled_array = Shuffle_Array.ModernFisher_YatesAlgorithm.shuffle(unshuffled_array);
        int distinct_elements = shuffled_array.Distinct().Count();

        Assert.Equal(shuffled_array.Length, distinct_elements);
    }
}