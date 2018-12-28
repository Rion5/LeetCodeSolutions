using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 832. Flipping an Image
    /// Given a binary matrix A, we want to flip the image horizontally, then invert it, and return the resulting image.
    /// IE) Input:   [ [1,1,0], [1,0,1], [0,0,0] ]
    ///     Output:  [ [1,0,0], [0,1,0], [1,1,1] ]
    /// Explanation: First reverse each row: [ [0,1,1], [1,0,1], [0,0,0] ]
    ///              Then, invert the image: [ [1,0,0], [0,1,0], [1,1,1] ]
    /// </summary>
    public class FlippingAnImage : Solution
    {
        private int[][] _arr;

        public FlippingAnImage(int[][] array)
        {
            this._arr = array;
        }

        int[][] FlipAndInvertImage(int[][] array)
        {
            //Goals: Given a Binary 2D array,
            //1) Reverse the array,
            //2) Flip the numbers
            int[][] results = new int[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                //Create inside array
                results[i] = new int[array[i].Length];
                int index = 0;
                //Reverse the array
                for (int j = array[i].Length - 1; j >= 0; j--)
                {
                    //Flip the numbers
                    if (array[i][j] == 1)
                    {
                        results[i][index++] = 0;
                    }
                    else
                    {
                        results[i][index++] = 1;
                    }
                }
            }
            return results;
        }

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = FlipAndInvertImage(this._arr);
            watch.Stop();
            string resultString =
                $"[ [{results[0][0]},{results[0][1]},{results[0][2]}], [{results[1][0]},{results[1][1]},{results[1][2]}], [{results[2][0]},{results[2][1]},{results[2][2]}] ]";
            Console.WriteLine($"832. Flipping an Image\n" +
                              $"Input:  [ [1,1,0], [1,0,1], [0,0,0] ]\n" +
                              $"Result: {resultString} \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
