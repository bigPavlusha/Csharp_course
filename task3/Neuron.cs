using System;
using System.Linq;

namespace task3
{
    class Neuron
	{
		public double a { get; set; } = 0.02; //Открытый доступ для изменения переменной
		public double b { get; set; } = -0.4;//Открытый доступ для изменения переменной
		public double[] w { get; set; } = { 0, 0, 0, 0 };//Открытый доступ для изменения переменной
		public int c { get; set; } = 0;//Открытый доступ для изменения переменной


		//private int[][] X; //Закрытый доступ для раскрытия структуры (не хотел модифицировать код, решил раскрыть стурктуру)
		//private int[] Y; //Закрытый доступ для раскрытия структуры (не хотел модифицировать код, решил раскрыть стурктуру)

		public Neuron(InputData[] datas)
		{
			while (learn(datas))
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

		bool learn(InputData[] datas) //Закрытый доступ по умолчанию
		{
			double[] w_ = new double[w.Length];

			Array.Copy(w, w_, w.Length);

			int i = 0;
			foreach (InputData d in datas)
			{
				int y = d.Y;
				for (int j = 0; j < d.X.Length; j++)
				{
					w[j] += a * (y - calculate(d.X)) * d.X[j];
				}
			}
			return !Enumerable.SequenceEqual(w_, w);
		}

	}
}
