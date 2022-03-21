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
            else if (chaine.Length == 2 && chaine[0] == chaine[1])
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