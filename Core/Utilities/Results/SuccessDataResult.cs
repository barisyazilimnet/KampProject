using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<Type> : DataResult<Type>
    {
        public SuccessDataResult(Type data, string message) : base(data, true, message)
        {

        }
        public SuccessDataResult(Type data) : base(data, true)
        {

        }
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }
        public SuccessDataResult() : base(default, true)
        {
               
        }
    }
}
