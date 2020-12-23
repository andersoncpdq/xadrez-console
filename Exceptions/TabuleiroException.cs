using System;

namespace Exceptions
{
    class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
