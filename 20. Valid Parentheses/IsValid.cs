public class Solution {
    public bool IsValid(string s) {
        // Create a stack to track the opening brackets.
        var stack = new Stack<char>();

        // Iterate through the string, character by character.
        foreach (char c in s) {
            if (c == '(' || c == '[' || c == '{') {
                // If the current character is an opening bracket, push it onto the stack.
                stack.Push(c);
            } else {
                // If the stack is empty or the top element does not match the closing bracket,
                // the string is invalid.
                if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), c)) {
                    return false;
                }
            }
        }

        // If the stack is not empty, the string is invalid.
        return stack.Count == 0;
    }

    // Helper method to determine if a pair of brackets match.
    private bool IsMatchingPair(char opening, char closing) {
        return (opening == '(' && closing == ')') ||
               (opening == '[' && closing == ']') ||
               (opening == '{' && closing == '}');
    }
}
