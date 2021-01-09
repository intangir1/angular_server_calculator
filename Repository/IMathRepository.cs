using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcServerTrain
{
	public interface IMathRepository
	{
		int Plus(int num1, int num2);
		int Minus(int num1, int num2);
		int Mult(int num1, int num2);
		double Div(int num1, int num2);
	}
}
