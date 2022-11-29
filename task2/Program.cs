using System;
using System.Linq;

class FormalNeuronDemo
{
	class Neuron
	{
		public double a { get; set; } = 0.02; //Открытый доступ для изменения переменной
		public double b { get; set; } = -0.4;//Открытый доступ для изменения переменной
		public double[] w { get; set; } = { 0, 0, 0, 0 };//Открытый доступ для изменения переменной
		public int c { get; set; } = 0;//Открытый доступ для изменения переменной


		private int[][] X; //Закрытый доступ для раскрытия структуры (не хотел модифицировать код, решил раскрыть стурктуру)
		private int[] Y; //Закрытый доступ для раскрытия структуры (не хотел модифицировать код, решил раскрыть стурктуру)

		public Neuron(InputData[] datas)
		{
			X = new int[datas.Length][];
			Y = new int[datas.Length];
			for (int i = 0; i < datas.Length; i++)
			{
				X[i] = datas[i].X;
				Y[i] = datas[i].Y;
			}
			while (learn(X, Y))
			{
				if (c++ > 10000) break;
			}
		}

		public double calculate(int[] x) //Открытый доступ, потому что используется вне класса (в Main)
		{
			double s = b;
			for (int i = 0; i < w.Length; i++) s += w[i] * x[i];
			return (s > 0) ? 1 : 0;
		}

		bool learn(int[][] X, int[] Y) //Закрытый доступ по умолчанию
		{
			double[] w_ = new double[w.Length];

			Array.Copy(w, w_, w.Length);

			int i = 0;
			foreach (int[] x in X)
			{
				int y = Y[i++];
				for (int j = 0; j < x.Length; j++)
				{
					w[j] += a * (y - calculate(x)) * x[j];
				}
			}
			return !Enumerable.SequenceEqual(w_, w);
		}

	}

	/*
	static int[][] X = {
		new int [] {0, 0, 0, 0},
		new int [] {0, 0, 0, 1},
		new int [] {1, 1, 1, 0},
		new int [] {1, 1, 1, 0},
		new int [] {1, 1, 1, 1}
	};

	static int[] Y = { 0, 1, 1, 0, 1 };
	
	 */

	struct InputData //Создал стурктуру, скорее ради удобства заполнения данных, нежели для скорости работы программы
	{
		public int[] X;
		public int Y;



		public InputData(int[] dataX, int dataY) //Конструктор для заполнения данных стурктуры
		{
			X = dataX;
			Y = dataY;
		}

		public void Print() => Console.WriteLine($"X: {X}  Y: {Y}"); //Просмотр данных структуры
	}

	static InputData[] VerifiedData = //массив выходных (обучаемых данных программы)
	{
		new InputData (new int [] {0, 0, 0, 0}, 0),
		new InputData (new int [] {0, 0, 0, 1}, 1),
		new InputData (new int [] {1, 1, 1, 0}, 1),
		new InputData (new int [] {1, 1, 1, 0}, 0),
		new InputData (new int [] {1, 1, 1, 1}, 1),

	};

	

	static int[][] Test = {
		new int [] {0, 0, 0, 0},
		new int [] {0, 0, 0, 1},
		new int [] {0, 1, 0, 1},
		new int [] {0, 1, 1, 0},
		new int [] {1, 1, 1, 0},
		new int [] {1, 1, 1, 1}
	};

	public static int Main()
	{
		Neuron neuron = new Neuron(VerifiedData);
		Console.WriteLine("[{0}] {1}",
			string.Join(", ", neuron.w),
			neuron.c
			);

		foreach (int[] test in Test)
		{
			Console.WriteLine("[{0}] {1} {2}",
				string.Join(", ", test),
				test[3],
				neuron.calculate(test)
			);
		}
		return 0;
	}
}