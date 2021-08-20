using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBoxPracticalTask.ResultCaching
{
    public abstract class BaseFigure
    {
        public float _square;
        public float Square { get => _square; private set => _square = value; }
        protected float SetNewSquare()
        {
            return Square = CalculateSquare();
        }
        protected abstract float CalculateSquare();
        protected void SizeCheck(double result, string exMessage)
        {
            if (result > float.MaxValue)
            {
                throw new OutOfMemoryException(exMessage);
            }
        }
    }

}
