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


		public Neuron(InputData[] datas) //Конструктор принимает стурктуру InputData
		{
			while (learn(datas)) //Функция learn - работает со структурой IputData
			{
				if (c++ > 10000) break;
			}
		}

		public double calculate(int[] x) //Открытый доступ, потому что используется вне класса (в Main), остался неизменныый за счёт структуры структуры
		{
			double s = b;
			for (int i = 0; i < w.Length; i++) s += w[i] * x[i];
			return (s > 0) ? 1 : 0;
		}

		bool learn(InputData[] datas) //Закрытый доступ по умолчанию, работаем со структурой InputData
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
