public class Solution {
    public int LongestValidParentheses(string s) {

        int length = 0;
        Stack<char> myStack = new Stack<char>();

        for(int i = 0; i < s.Length; i++){

            if(s[i] == '(')
            {

                myStack.Push(s[i]);     
            }
            else if(myStack.Count > 0 && myStack.Peek() == '(')
                {
                    length += 2;
                    myStack.Pop();
                } 
            
            }

            return length;
        }

}
