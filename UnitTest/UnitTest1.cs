namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBinaryGap()
        {
            Codity.BinaryGap bg = new Codity.BinaryGap();
            Assert.AreEqual(4, bg.BinaryGapFunc(529));
            Assert.AreEqual(1, bg.BinaryGapFunc(20));
           
        }
    }
}