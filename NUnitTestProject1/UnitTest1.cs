using NUnit.Framework;
using Spartez;

namespace NUnitTestProject1
{
    public class Tests
    {
        [TestCase("kajax", 1)]
        [TestCase("abccba", 0)]
        [TestCase("kbjax", 2)]
        public void Test1(string input, int count)
        {
            Palindrome p = new Palindrome();
            var result = p.GetPalindromeOrder(input);
            Assert.AreEqual(count, result);
        }
    }
}