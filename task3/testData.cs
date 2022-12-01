using System;

namespace task3
{
    public struct testData
    {
        public int[][] testDatas
        {
            get
            {
                return new int[][] 
                {
                    new int [] {0, 0, 0, 0},
                    new int [] {0, 0, 0, 1},
                    new int [] {0, 1, 0, 1},
                    new int [] {0, 1, 1, 0},
                    new int [] {1, 1, 1, 0},
                    new int [] {1, 1, 1, 1}
                };
            }
        }
    }
}
