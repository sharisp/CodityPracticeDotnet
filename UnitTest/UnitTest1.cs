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

        [TestMethod]
        public void TestCycliRotation()
        {
            var cy = new Codity.CyclicRotation();
            int[] A1 = { 3, 8, 9, 7, 6 };
            int K1 = 3;
            int[] expected1 = { 9, 7, 6, 3, 8 };
            var get = cy.CyclicRotationFunc(A1, K1);
       
            CollectionAssert.AreEqual(expected1, get);

        }
    }
}