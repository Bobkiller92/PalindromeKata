using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeKata.Prod;

namespace PalindromeKata.Test
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void ShouldReturnTrueForALetter()
        {
            string chaine = "a";

            bool result = Palindrome.EstUnPalindrome(chaine);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnTrueForMLetter()
        {
            string chaine = "m";

            bool result = Palindrome.EstUnPalindrome(chaine);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnFalseForTwoDifferentLetters()
        {
            string chaine = "mr";

            bool result = Palindrome.EstUnPalindrome(chaine);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldReturnTrueForTwoMatchingLetters()
        {
            string chaine = "rr";

            bool result = Palindrome.EstUnPalindrome(chaine);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnTrueForThreeLettersPalindrom()
        {
            string chaine = "mom";

            bool result = Palindrome.EstUnPalindrome(chaine);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnFalseForNoPalindromThreeLetters()
        {
            string chaine = "mra";

            bool result = Palindrome.EstUnPalindrome(chaine);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldReturnTrueForFourLettersPalindrom()
        {
            string chaine = "abba";

            bool result = Palindrome.EstUnPalindrome(chaine);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnFalseForNoPalindromFourLetters()
        {
            string chaine = "abra";

            bool result = Palindrome.EstUnPalindrome(chaine);

            Assert.IsFalse(result);
        }
    }
}