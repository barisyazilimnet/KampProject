using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<Type> : Result, IDataResult<Type>
    {
        public DataResult(Type data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
        public DataResult(Type data, bool success) : base(success)
        {
            Data = data;
        }
        public Type Data { get; }
    }
}
