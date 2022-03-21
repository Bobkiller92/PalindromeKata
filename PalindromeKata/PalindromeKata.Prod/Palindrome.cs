namespace PalindromeKata.Prod
{
    public class Palindrome
    {
        public static bool EstUnPalindrome(string chaine)
        {
            bool premiereEtDerniereLettreIdentiques = chaine[0] == chaine[chaine.Length - 1];
            
            if (chaine.Length == 1)
            {
                return true;
            }

            if (chaine.Length == 2 && premiereEtDerniereLettreIdentiques)
            {
                return true;
            }

            if (premiereEtDerniereLettreIdentiques)
            {
                string sousChaineSansPremiereEtDerniereLettre = chaine.Substring(1, chaine.Length - 2);
                return EstUnPalindrome(sousChaineSansPremiereEtDerniereLettre);
            }
            else
            {
                return false;
            }
        }       
    }
}