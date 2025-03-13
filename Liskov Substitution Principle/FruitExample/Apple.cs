using FruitExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitExample
{
	public class Apple : IApple
	{
		public virtual string GetColor()
		{
			return "Red";
		}
	}
}
