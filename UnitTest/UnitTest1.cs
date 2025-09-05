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
            var get1 = cy.CyclicRotationFunc(A1, K1);
       
            CollectionAssert.AreEqual(expected1, get1);

            int[] A2 = {};
            var get2 = cy.CyclicRotationFunc(A2, 5);
            CollectionAssert.AreEqual(A2, get2);

            int[] A3 = { 3, 8, 9, 7, 6 };
            int K3 = 8;
            int[] expected3 = { 9, 7, 6, 3, 8 };
            var get3 = cy.CyclicRotationFunc(A3, K3);

            CollectionAssert.AreEqual(expected3, get3);

        }
    }
}