using Exercise01;

namespace BigIntegerExtensionTests
{
    [TestClass]
    public class Exercise01_Test
    {
        [TestMethod]
        public void TestEquivalent_Hundred()
        {
            var result = CustomeIntergerExtensions.ToWords(100);
            Assert.AreEqual("One Hundred".ToLower().Trim(), result.ToLower().Trim());
        }

        [TestMethod]
        public void TestEquivalent_Thousands()
        {
            var result = CustomeIntergerExtensions.ToWords(1234);
            Assert.AreEqual("one thousand two hundred and thirty four".ToLower().Trim(), result.ToLower().Trim());
        }

        [TestMethod]
        public void TestEquivalent_Ten_Thousands()
        {
            var result = CustomeIntergerExtensions.ToWords(10789);
            Assert.AreEqual("ten thousand seven hundred and eighty nine".ToLower().Trim(), result.ToLower().Trim());
        }
        [TestMethod]
        public void TestEquivalent_Hundred_Thousands()
        {
            var result = CustomeIntergerExtensions.ToWords(100000);
            Assert.AreEqual("One hundred  thousand".ToLower().Trim(), result.ToLower().Trim());
        }

        [TestMethod]
        public void TestEquivalent_One_Millon()
        {
            var result = CustomeIntergerExtensions.ToWords(1000000);
            Assert.AreEqual("One Million".ToLower().Trim(), result.ToLower().Trim());
        }

        [TestMethod]
        public void TestEquivalent_Ten_Million()
        {
            var result = CustomeIntergerExtensions.ToWords(10000000);
            Assert.AreEqual("Ten Million".ToLower().Trim(), result.ToLower().Trim());
        }

        [TestMethod]
        public void TestEquivalent_Hundred_Million()
        {
            var result = CustomeIntergerExtensions.ToWords(100000000);
            Assert.AreEqual("one hundred  million".ToLower().Trim(), result.ToLower().Trim());
        }

        [TestMethod]
        public void TestEquivalent_Billion()
        {
            var result = CustomeIntergerExtensions.ToWords(1000000000);
            Assert.AreEqual("One Billion".ToLower().Trim(), result.ToLower().Trim());
        }

        [TestMethod]
        public void TestEquivalent_Trillion()
        {
            var result = CustomeIntergerExtensions.ToWords(1000000000000);
            Assert.AreEqual("One Trillion".ToLower().Trim(), result.ToLower().Trim());
        }

        [TestMethod]
        public void TestEquivalent_Quadrillion()
        {
            var result = CustomeIntergerExtensions.ToWords(1123987237443876235);
            Assert.AreEqual("one quintillion one hundred and twenty three quadrillion nine hundred and eighty seven trillion two hundred and thirty seven billion four hundred and forty three million eight hundred and seventy six thousand two hundred and thirty five".ToLower().Trim(), result.ToLower().Trim());
        }

        [TestMethod]
        public void TestEquivalent_Quintillion()
        {
            var result = CustomeIntergerExtensions.ToWords(8446744073709551615);
            Assert.AreEqual("eight quintillion four hundred and forty six quadrillion seven hundred and forty four trillion seventy three billion seven hundred and nine million five hundred and fifty one thousand six hundred and fifteen".ToLower().Trim(), result.ToLower().Trim());
        }
    }
}