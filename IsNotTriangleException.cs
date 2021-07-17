using System;

namespace DexCompareTo
{
    class IsNotTriangleException : Exception
    {
        private string _Message;

        public IsNotTriangleException(string message)
        {
            _Message = message;
        }

        public override string ToString()
        {
            return _Message;
        }
    }
}
