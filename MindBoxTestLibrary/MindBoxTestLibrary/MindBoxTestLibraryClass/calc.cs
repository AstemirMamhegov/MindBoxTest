using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibraryClass
{
    public class FigCalc
    {
        public static double Calc(IFigure obj)
        {
            if (obj.sides.Count()==1)
            {
                //circle
            }
            else if (obj.sides.Count() == 3)
            {
                //triangle
            }
            else if (obj.sides.Count() == 4)
            {
                //rectangle
            }
            return 0;
        }
    }
    public class IFigure
    {
        public List<int> sides;
        
    }
    
}
