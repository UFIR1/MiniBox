using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBoxPracticalTask.MemoryOptimize
{
    public abstract class BaseFigure
    {
        public abstract float GetSquare();
        protected void SizeCheck(double result, string exMessage)
        {
            if (result > float.MaxValue)
            {
                throw new OutOfMemoryException(exMessage);
            }
        }
    }
    
}
