using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcServerTrain
{
	public class MathManager : IMathRepository
	{

		public int Plus(int num1, int num2)
		{
			return num1 + num2;
		}


		public int Minus(int num1, int num2)
		{
			return num1 - num2;
		}


		public int Mult(int num1, int num2)
		{
			return num1 * num2;
		}


		public double Div(int num1, int num2)
		{
			return num1 / num2;
		}

		
	}
}
