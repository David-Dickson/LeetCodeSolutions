/*
In the example below, the TwoSum method takes in an array of numbers and a target and uses a dictionary to store the numbers as keys and their indices as values. 
It iterates through the array of numbers and checks if the target minus the current number is in the dictionary. 
If it is, it returns the indices of the current number and the number in the dictionary. 
If the target minus the current number is not in the dictionary, it checks if the current number is already in the dictionary. 
If it is not, it adds the current number and its index to the dictionary. 
This ensures that we only add unique numbers to the dictionary and avoid adding the same number multiple times. 
After iterating through the entire array, if the indices of the two numbers that add up to the target have not been found, it returns an empty array.

This approach has a time complexity of O(n), which is less than O(n^2).
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        // Create an empty dictionary to store the numbers as keys and their indices as values.
        
        var dict = new Dictionary<int, int>();

        // Iterate through the array of numbers.
        
        for (int i = 0; i < nums.Length; i++) 
        {
            int num = nums[i];

            // If the target minus the current number is in the dictionary,
            // return the indices of the current number and the number in the dictionary.
            
            if (dict.ContainsKey(target - num)) 
            {
                return new int[] { i, dict[target - num] };
            }

            // If the target minus the current number is not in the dictionary,
            // add the current number and its index to the dictionary.
            // However, do this only after checking if the target minus the current number is in the dictionary.
            // This ensures that we only add unique numbers to the dictionary.
            
            if (!dict.ContainsKey(num)) 
            {
                dict[num] = i;
            }
        }

        // If the indices of the two numbers that add up to the target have not been found,
        // return an empty array.
      
        return new int[0];
    }
}
