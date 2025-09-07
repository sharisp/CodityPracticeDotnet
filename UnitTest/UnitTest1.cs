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

            int[] A2 = { };
            var get2 = cy.CyclicRotationFunc(A2, 5);
            CollectionAssert.AreEqual(A2, get2);

            int[] A3 = { 3, 8, 9, 7, 6 };
            int K3 = 8;
            int[] expected3 = { 9, 7, 6, 3, 8 };
            var get3 = cy.CyclicRotationFunc(A3, K3);

            CollectionAssert.AreEqual(expected3, get3);

        }


        [TestMethod]
        public void TestOddOccurrencesInArrayByDictionary()
        {
            var oddOccurrences = new Codity.OddOccurrencesInArray();
            int[] A1 = { 9, 3, 9, 3, 9, 7, 9 };
            Assert.AreEqual(7, oddOccurrences.OddOccurrencesInArrayByDictionary(A1));

            int[] A2 = { 9, 3, 9, 3, 9, 7, 9, 9, 9, 9, 7 };
            Assert.AreEqual(9, oddOccurrences.OddOccurrencesInArrayByDictionary(A2));
        }

        [TestMethod]
        public void TestOddOccurrencesInArrayByXOR()
        {
            var oddOccurrences = new Codity.OddOccurrencesInArray();
            int[] A1 = { 9, 3, 9, 3, 9, 7, 9 };
            Assert.AreEqual(7, oddOccurrences.OddOccurrencesInArrayXOR(A1));

            int[] A2 = { 9, 3, 9, 3, 9, 7, 9, 9, 9, 9, 7 };
            Assert.AreEqual(9, oddOccurrences.OddOccurrencesInArrayXOR(A2));
        }

        [TestMethod]
        public void TestFrogJmpFunc()
        {
            var jmp = new Codity.FrogJmp();
            Assert.AreEqual(3, jmp.FrogJmpFunc(10, 85, 30));

            Assert.AreEqual(3, jmp.FrogJmpFunc(85, 10, 30));

            Assert.AreEqual(3, jmp.FrogJmpFunc(100, 10, 30));
        }
    }
}