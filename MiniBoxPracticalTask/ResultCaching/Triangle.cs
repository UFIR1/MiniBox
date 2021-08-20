using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBoxPracticalTask.ResultCaching
{
    sealed public class Triangle : BaseFigure
    {
        private float _a;
        private float _b;
        private float _c;
        public float A { get => _a; set { CorrectTriangleCheck(value, B, C); _a = value; SetNewSquare(); } }
        public float B { get => _b; set { CorrectTriangleCheck(A, value, C); _b = value; SetNewSquare(); } }
        public float C { get => _c; set { CorrectTriangleCheck(A, B, value); _c = value; SetNewSquare(); } }
        public Triangle(float a, float b, float c)
        {
            CorrectTriangleCheck(a, b, c);
            _a = a;
            _b = b;
            _c = c;
            SetNewSquare();
        }
        protected override float CalculateSquare()
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
