using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibraryClass.Exception
{
    public class InterfaceNotImplementedException : Exception
    {
        public InterfaceNotImplementedException(Type interfaceType, Type objectType)
        {

        }
    }
}
