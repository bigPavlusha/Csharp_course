using System;

namespace task3
{
    struct InputData //Структура для удобства заполненя и работы с входными данными (удобство заполнения и организации работы)
	{
		public int[] X; //Массив Х
		public int Y; //Массив Y

		public InputData(int[] dataX, int dataY) //Конструктор для заполнения данных стурктуры
		{
			X = dataX;
			Y = dataY;
		}

		public InputData[] inputDatas //Поле массива структуры
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
