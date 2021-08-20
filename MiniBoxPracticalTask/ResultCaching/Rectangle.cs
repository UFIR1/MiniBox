using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBoxPracticalTask.ResultCaching
{
    /*не закрыт потому что ожидается квадрат*/
    public class Rectangle : BaseFigure /*по хорошему должен быть интерфейсом четырехугольника но в тз момент опущен*/
    {
        private float _a;
        private float _b;
        public float A { get => _a; private set { _a = value; SetNewSquare(); } }
        public float B { get => _b; set { _b = value; SetNewSquare(); } }
        public Rectangle(float a, float b) 
        {
            _a = a;
            _b = b;
            SetNewSquare();
        }
        protected override float CalculateSquare()
        {
            double result = A * B;
            SizeCheck(result, "I'm very big Rectangle (((");
            return (float)result;
        }
    }
}
