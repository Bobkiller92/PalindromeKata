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

    }
}