using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 200. Number of Islands
    /// Given a 2d map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.
    /// IE) Input  :  [11000]
    ///               [11000]
    ///               [00100]
    ///               [00011]
    ///     Output :  3
    /// Explanation:  There are 3 separate islands, 1 in the top left, another 1 in the center, and last 1 in the bottom right
    /// </summary>
    public class NumberOfIslands : Solution
    {
        private char[,] _grid;

        public NumberOfIslands(char[,] grid)
        {
            this._grid = grid;
        }

        private int numIslands(char[,] grid)
        {
            // Base case
            if (grid == null || grid.Length == 0) return 0;
            int islandCount = 0;

            // Iterate through 2d array
            //  if the char == '1' then we found an island, therefore increment the counter and check if its neighboring positions are part of the island
            int rows = grid.GetLength(0);       // Gets the 1st dimension size [x, ]
            int columns = grid.GetLength(1);    // Gets the 2nd dimension size [ ,x]
            for (int row = 0; row <= rows - 1; row++)
            {
                for (int column = 0; column <= columns - 1; column++)
                {
                    if (grid[row, column] == '1')
                    {
                        islandCount++;
                        travelIsland(grid,row,column);
                    }
                }
            }
            return islandCount;
        }

        private void travelIsland(char[,] grid, int row, int column)
        {
            // Exit out of the function if you reached the end of the grid, or island, or the position has already been traveled on
            if (row < 0 || column < 0 || row == grid.GetLength(0) || column == grid.GetLength(1) ||
                grid[row, column] == '0' || grid[row, column] == 'T')
            {
                return;
            }

            // Otherwise mark this position 'T' to know that we have already traveled here
            //  And continue to travel to neighboring positions
            grid[row, column] = 'T';
            travelIsland(grid, row + 1, column);    // Travel Right
            travelIsland(grid, row - 1, column);    // Travel Left
            travelIsland(grid, row, column + 1);    // Travel Up
            travelIsland(grid, row, column - 1);    // Travel Down
        }
        public override void PrintExample()
        {
            throw new NotImplementedException();
        }
    }
}
