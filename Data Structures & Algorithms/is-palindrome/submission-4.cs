public class Solution {
    public bool IsPalindrome(string s) 
    {
        int Left = 0;
        int Right = s.Length - 1;

        while(Left <= Right)
        {
            if(!char.IsLetterOrDigit(s[Left]) || s[Left] == ' ')
            {
                Left++;
                continue;
            }

            if(!char.IsLetterOrDigit(s[Right]) || s[Right] == ' ')
            {
                Right--;
                continue;
            }
                
            if(char.ToLower(s[Right]) != char.ToLower(s[Left]))
                return false;

            Left++;
            Right--;
        }

        return true;
    }
}