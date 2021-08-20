using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBoxPracticalTask.MemoryOptimize
{
    sealed public class Circle : BaseFigure
    {
        private float _radius;
        public float Radius { get => _radius; private set => _radius = value; }
        public Circle(float radius)
        {
            Radius = radius;
        }

        public override float GetSquare()
        {
            double result = Math.PI * (Math.Pow(_radius, 2));
            SizeCheck(result, "I'm very big Circle (((");
            return (float)result;
        }
    }
}
