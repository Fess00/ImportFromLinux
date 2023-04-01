using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA_2
{
    public interface IPoint
    {
        public void SetPoint(int x, int y);
        public int GetPointX();
        public int GetPointY();
    }
}