using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PalindromeKata.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnTrueForALetter()
        {
            string chaine = "a";

            bool result = EstUnPalindrome(chaine);

            Assert.IsTrue(result);
        }

        private bool EstUnPalindrome(string chaine)
        {
            return true;
        }
    }
}