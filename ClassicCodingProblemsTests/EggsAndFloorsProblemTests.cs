using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dvinun.ClassicCodingProblems;

namespace Dvinun.CodingExercises.Tests
{
    [TestClass()]
    public class EggsAndFloorsProblemTests
    {
        [TestMethod()]
        public void GetEggDropTrialsTest()
        {
            EggsAndFloorsProblem eggsAndFloorsProblem = new EggsAndFloorsProblem();
            int numberOfFloors = 0;
            int numberOfEggs = 0;
            int numberOfMinimumTrials = 0;

            numberOfFloors = 0;
            numberOfEggs = 0;
            numberOfMinimumTrials = eggsAndFloorsProblem.GetEggDropTrials(numberOfFloors, numberOfEggs);
            Assert.AreEqual(0, numberOfMinimumTrials);

            numberOfFloors = 1;
            numberOfEggs = 4;
            numberOfMinimumTrials = eggsAndFloorsProblem.GetEggDropTrials(numberOfFloors, numberOfEggs);
            Assert.AreEqual(1, numberOfMinimumTrials);

            numberOfFloors = 27;
            numberOfEggs = 1;
            numberOfMinimumTrials = eggsAndFloorsProblem.GetEggDropTrials(numberOfFloors, numberOfEggs);
            Assert.AreEqual(27, numberOfMinimumTrials);

            numberOfFloors = 8;
            numberOfEggs = 3;
            numberOfMinimumTrials = eggsAndFloorsProblem.GetEggDropTrials(numberOfFloors, numberOfEggs);
            Assert.AreEqual(4, numberOfMinimumTrials);

            numberOfFloors = 100;
            numberOfEggs = 2;
            numberOfMinimumTrials = eggsAndFloorsProblem.GetEggDropTrials(numberOfFloors, numberOfEggs);
            Assert.AreEqual(14, numberOfMinimumTrials);
        }
    }
}