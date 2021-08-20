using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBoxPracticalTask.MemoryOptimize
{
    /*не закрыт потому что ожидается квадрат*/
    public class Rectangle : BaseFigure /*по хорошему должен быть интерфейсом четырехугольника но в тз момент опущен*/
    {
        private float _a;
        private float _b;
        public float A { get => _a; private set => _a = value; }
        public float B { get => _b; private set => _b = value; }
        public Rectangle(float a, float b)
        {
            A = a;
            B = b;
        }

        public override float GetSquare()
        {
            double result = A * B;
            SizeCheck(result, "I'm very big Rectangle (((");
            return (float)result;
        }


    }
}
