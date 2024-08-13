using ParenthesisCheckerApp;

namespace ParenthesisCheckerTests
{
    [TestClass]
    public class ParenthesisCheckerUnitTests
    {
        [TestMethod]
        public void TestEmptyString()
        {
            Assert.IsTrue(ParenthesisChecker.IsBalanced(""));
        }

        [TestMethod]
        public void TestSingleTypeBalanced()
        {
            Assert.IsTrue(ParenthesisChecker.IsBalanced("()"));
            Assert.IsTrue(ParenthesisChecker.IsBalanced("[]"));
            Assert.IsTrue(ParenthesisChecker.IsBalanced("{}"));
        }

        [TestMethod]
        public void TestSingleTypeUnbalanced()
        {
            Assert.IsFalse(ParenthesisChecker.IsBalanced("("));
            Assert.IsFalse(ParenthesisChecker.IsBalanced("["));
            Assert.IsFalse(ParenthesisChecker.IsBalanced("{"));
        }

        [TestMethod]
        public void TestMixedTypeBalanced()
        {
            Assert.IsTrue(ParenthesisChecker.IsBalanced("({[]})"));
            Assert.IsTrue(ParenthesisChecker.IsBalanced("{[()]}"));
        }

        [TestMethod]
        public void TestMixedTypeUnbalanced()
        {
            Assert.IsFalse(ParenthesisChecker.IsBalanced("({[})"));
            Assert.IsFalse(ParenthesisChecker.IsBalanced("[(])"));
        }

        [TestMethod]
        public void TestNoParentheses()
        {
            Assert.IsTrue(ParenthesisChecker.IsBalanced("abc"));
        }
    }
}