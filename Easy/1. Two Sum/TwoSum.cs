/*
In the example below, the TwoSum method takes in an array of numbers and a target and uses a dictionary to store the numbers as keys and their indices as values. 
It iterates through the array of numbers and checks if the target minus the current number is in the dictionary. 
If it is, it returns the indices of the current number and the number in the dictionary. 
If the target minus the current number is not in the dictionary, it adds the current number and its index to the dictionary. 
After iterating through the entire array, if the indices of the two numbers that add up to the target have not been found, it returns an empty array.
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    
        // Create an empty dictionary to store the numbers as keys and their indices as values.
        var dict = new Dictionary<int, int>();

        // Iterate through the array of numbers.
        for (int i = 0; i < nums.Length; i++) 
        {
            int num = nums[i];
            
            // For each number in the array:
            // Check IF the target minus the current number is in the dictionary,
            // return the indices of the current number and the number in the dictionary.
            
            if (dict.ContainsKey(target - num)) 
            {
                return new int[] { i, dict[target - num] };
            }

            // If the target minus the current number IS NOT in the dictionary,
            // add the current number and its index to the dictionary.
            
            dict[num] = i;
        }

        // If the indices of the two numbers that add up to the target have not been found,
        // return an empty array.
        
        return new int[0];
    }
}
