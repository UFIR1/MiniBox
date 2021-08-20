using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBoxPracticalTask.ResultCaching
{
    sealed public class Circle : BaseFigure
    {
        private float _radius;
        public float Radius { get => _radius; set { _radius = value; SetNewSquare(); } }
        public Circle(float radius)
        {
            _radius = radius;
            SetNewSquare();
        }
        protected override float CalculateSquare()
        {
            double result = Math.PI * (Math.Pow(_radius, 2));
            SizeCheck(result, "I'm very big Circle (((");
            return (float)result;
        }
    }
}
