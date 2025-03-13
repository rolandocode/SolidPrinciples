using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorectFruitExample
{
    public class FruitManager
    {
        private IFruit _apple;
        private IFruit _orange;
        public FruitManager(Apple apple, Orange orange)
        {
            _apple = apple;
            _orange = orange;
        }

        public void run()
        {
            Console.WriteLine("Apple is now " + _apple.GetColor());
        }
    }
}
