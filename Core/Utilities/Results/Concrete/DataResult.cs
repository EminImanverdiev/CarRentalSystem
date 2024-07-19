using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(string message,bool success,T data):base(success, message)
        {
            Data = data;    
        }
        public DataResult(bool success, T data) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
