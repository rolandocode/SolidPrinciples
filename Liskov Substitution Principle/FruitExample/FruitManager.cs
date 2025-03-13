using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitExample
{
	public class FruitManager
	{
		private Apple _apple;
		private Orange _orange;
		public FruitManager(Apple apple, Orange orange)
		{
			_orange = orange;
			_apple = orange;
		}

		public void run()
		{
			Console.WriteLine("Apple is color: " + _apple.GetColor());

		}
	}
}
