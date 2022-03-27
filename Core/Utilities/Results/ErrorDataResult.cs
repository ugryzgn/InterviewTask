using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //daha kolay kullanımlı bir kod çalıştırmak için dataresult'ı iki farklı (success/error) duruma bölerek
    //farklı senaryolar için kullandım.
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, false)
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
