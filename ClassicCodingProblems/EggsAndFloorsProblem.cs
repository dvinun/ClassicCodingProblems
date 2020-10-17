using System;

namespace Dvinun.ClassicCodingProblems
{
    public class EggsAndFloorsProblem
    {
        const int MAX_TRIALS = 999;

        public int GetEggDropTrials(int numberOfFloors, int numberOfEggs)
        {
            var trialsEggsVsFloor = new int[numberOfEggs + 1, numberOfFloors + 1];

            for (int eggIndex = 1; eggIndex <= numberOfEggs; eggIndex++)
                for (int floorIndex = 1; floorIndex <= numberOfFloors; floorIndex++)
                    trialsEggsVsFloor[eggIndex, floorIndex] = MAX_TRIALS;

            for (int floorIndex = 1; floorIndex <= numberOfFloors; floorIndex++)
                trialsEggsVsFloor[1, floorIndex] = floorIndex;

            for (int eggIndex = 1; eggIndex <= numberOfEggs; eggIndex++)
                trialsEggsVsFloor[eggIndex, 1] = 1;

            for (int eggIndex = 2; eggIndex <= numberOfEggs; eggIndex++)
                for (int floorIndex = 2; floorIndex <= numberOfFloors; floorIndex++)
                    trialsEggsVsFloor[eggIndex, floorIndex] =
                        1 + min(getMaxTrials(floorIndex, eggIndex, trialsEggsVsFloor));

            return trialsEggsVsFloor[numberOfEggs, numberOfFloors];
        }

        int min(int[] array)
        {
            if (array == null || array.Length == 0) return 0;
            if (array.Length == 1) return array[0];
            Array.Sort(array);
            return array[0];
        }

        int[] getMaxTrials(int endFloor, int totalEggs, int[,] trialsEggsVsFloor)
        {
            var maxTrials = new int[endFloor + 1];
            for (int i = 0; i < maxTrials.Length; i++) maxTrials[i] = MAX_TRIALS;

            for (int floorIndex = 1; floorIndex <= endFloor; floorIndex++)
            {
                int trialsRequiredWhenEggDoesntBreak = trialsEggsVsFloor[totalEggs, endFloor - floorIndex];
                int trialsRequiredWhenEggBreaks = trialsEggsVsFloor[totalEggs - 1, floorIndex - 1];
                maxTrials[floorIndex] = trialsRequiredWhenEggDoesntBreak > trialsRequiredWhenEggBreaks ?
                    trialsRequiredWhenEggDoesntBreak : trialsRequiredWhenEggBreaks;
            }

            return maxTrials;
        }
    }
}
