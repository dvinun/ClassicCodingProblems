using System;
using System.Collections.Generic;
using System.Linq;

namespace Dvinun.ClassicCodingProblems
{
    public class MagicSquares
    {
        // Works only for 3x3
        public static int TransformToMagicSquareWithMinimumCost(int[,] square)
        {
            // 1. Generate all the magic squares
            List<int[,]> listMagicSquares = generateAllPossibleMagicSquares(9);

            // 2. Transform the given input square to the magic square and select the min cost one
            int minCost = 999;
            foreach (var magicSquare in listMagicSquares)
            {
                minCost = Math.Min(minCost, getCostToTransformToMagicSquare(square, magicSquare));
            }

            return minCost;
        }

        static int getCostToTransformToMagicSquare(int[,] inputSquare, int[,] magicSquare)
        {
            int Cell00 = Math.Abs(inputSquare[0, 0] - magicSquare[0, 0]);
            int Cell01 = Math.Abs(inputSquare[0, 1] - magicSquare[0, 1]);
            int Cell02 = Math.Abs(inputSquare[0, 2] - magicSquare[0, 2]);

            int Cell10 = Math.Abs(inputSquare[1, 0] - magicSquare[1, 0]);
            int Cell11 = Math.Abs(inputSquare[1, 1] - magicSquare[1, 1]);
            int Cell12 = Math.Abs(inputSquare[1, 2] - magicSquare[1, 2]);

            int Cell20 = Math.Abs(inputSquare[2, 0] - magicSquare[2, 0]);
            int Cell21 = Math.Abs(inputSquare[2, 1] - magicSquare[2, 1]);
            int Cell22 = Math.Abs(inputSquare[2, 2] - magicSquare[2, 2]);

            return
                Cell00 + Cell01 + Cell02 +
                Cell10 + Cell11 + Cell12 +
                Cell20 + Cell21 + Cell22;
        }

        static List<int[,]> generateAllPossibleMagicSquares(int size)
        {
            List<int[,]> magicSquares = new List<int[,]>();

            List<string> allPossibleCombinations = CommonDotNet.Utils.Math.GenerateAllCombinations("123456789").ToList();
            allPossibleCombinations.ForEach(item => {
                int[,] squareArray = make2DArray(item.ToArray().Select(charItem => charItem - '0').ToArray(), 3, 3);
                if (isItAMagicSquare(squareArray)) magicSquares.Add(squareArray);
            });

            return magicSquares;
        }

        static bool isItAMagicSquare(int[,] squareArray)
        {
            if ((squareArray[0, 0] + squareArray[0, 1] + squareArray[0, 2]) != 15) return false; 
            if ((squareArray[1, 0] + squareArray[1, 1] + squareArray[1, 2]) != 15) return false; 
            if ((squareArray[2, 0] + squareArray[2, 1] + squareArray[2, 2]) != 15) return false;

            if ((squareArray[0, 0] + squareArray[1, 0] + squareArray[2, 0]) != 15) return false;
            if ((squareArray[0, 1] + squareArray[1, 1] + squareArray[2, 1]) != 15) return false;
            if ((squareArray[0, 2] + squareArray[1, 2] + squareArray[2, 2]) != 15) return false;

            if ((squareArray[0, 0] + squareArray[1, 1] + squareArray[2, 2]) != 15) return false;
            if ((squareArray[0, 2] + squareArray[1, 1] + squareArray[2, 0]) != 15) return false;

            return true;

        }

        private static T[,] make2DArray<T>(T[] input, int height, int width)
        {
            T[,] output = new T[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    output[i, j] = input[i * width + j];
                }
            }
            return output;
        }

    }
}
