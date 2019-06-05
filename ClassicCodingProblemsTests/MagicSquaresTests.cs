using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dvinun.ClassicCodingProblems;

namespace Dvinun.CodingExercises.Tests
{
    [TestClass()]
    public class MagicSquaresTests
    {
        [TestMethod()]
        public void TransformToMagicSquareWithMinimumCostTest()
        {
            Assert.AreEqual(24, MagicSquares.TransformToMagicSquareWithMinimumCost(new int[,]{
                                                                        { 1,2,3},
                                                                        { 4,5,6 },
                                                                        { 7,8,9} }));

            Assert.AreEqual(7, MagicSquares.TransformToMagicSquareWithMinimumCost(new int[,]{
                                                                        { 5,3,4},
                                                                        { 1,5,8 },
                                                                        { 6,4,2} }));

            Assert.AreEqual(1, MagicSquares.TransformToMagicSquareWithMinimumCost(new int[,]{
                                                                        { 4,9,2},
                                                                        { 3,5,7 },
                                                                        { 8,1,5 } }));

            Assert.AreEqual(4, MagicSquares.TransformToMagicSquareWithMinimumCost(new int[,]{
                                                                        { 4,8,2},
                                                                        { 4,5,7 },
                                                                        { 6,1,6 } }));

        }


    }
}