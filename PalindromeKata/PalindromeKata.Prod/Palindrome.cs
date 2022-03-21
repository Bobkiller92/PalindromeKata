namespace PalindromeKata.Prod
{
    public class Palindrome
    {
        public static bool EstUnPalindrome(string chaine)
        {
            if (chaine.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}