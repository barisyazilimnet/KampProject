using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<Type> : IResult
    {
        Type Data { get; }
    }
}
