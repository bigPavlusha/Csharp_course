using System;

namespace task3
{
    public struct testData //Структура для тестовых данных, удобство заполнения
    {
        public int[][] testDatas //Массив тестовых данных
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
