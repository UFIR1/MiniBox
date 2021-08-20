using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBoxPracticalTask.MemoryOptimize
{
    sealed public class Triangle : BaseFigure
    {
        private float _a;
        private float _b;
        private float _c;
        public float A { get => _a; private set => _a = value; }
        public float B { get => _b; private set => _b = value; }
        public float C { get => _c; private set => _c = value; }
        public Triangle(float a, float b, float c)
        {
            CorrectTriangleCheck(a, b, c);
            A = a;
            B = b;
            C = c;
        }
        public override float GetSquare()
        {
            double p = (A + B + C) / 2;
            double result = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            SizeCheck(result, "I'm very big Triangle (((");
            return (float)result;
        }
        public void CorrectTriangleCheck(float a, float b, float c)
        {
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new Exception("Incorrect Triangle");
            }
        }

    }
}
