using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibraryClass.Exception
{
    public class ReturnedNullException : Exception
    {
        public ReturnedNullException(MethodInfo methodInfo, Type objectType) { }
    }
}
