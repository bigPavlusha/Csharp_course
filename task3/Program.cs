using System;

namespace task3
{
	class FormulaNeuronNew
	{ 
		public static int Main()
		{
			InputData inputSet = new InputData();
			testData testSet = new testData();

			Neuron neuron = new Neuron(inputSet.inputDatas);
			Console.WriteLine("[{0}] {1}",
				string.Join(", ", neuron.w),
				neuron.c
				);

			foreach (int[] test in testSet.testDatas)
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
}
