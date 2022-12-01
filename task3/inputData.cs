using System;

namespace task3
{
    struct InputData //Создал стурктуру, скорее ради удобства заполнения данных, нежели для скорости работы программы
	{
		public int[] X;
		public int Y;

		public InputData(int[] dataX, int dataY) //Конструктор для заполнения данных стурктуры
		{
			X = dataX;
			Y = dataY;
		}

		public InputData[] inputDatas
        {
			get
            {
				return new InputData[]
                {
					new InputData (new int [] {0, 0, 0, 0}, 0),
					new InputData (new int [] {0, 0, 0, 1}, 1),
					new InputData (new int [] {1, 1, 1, 0}, 1),
					new InputData (new int [] {1, 1, 1, 0}, 0),
					new InputData (new int [] {1, 1, 1, 1}, 1),
				};
			}
		}

		public void Print() => Console.WriteLine($"X: {X}  Y: {Y}"); //Просмотр данных структуры
	}
};
