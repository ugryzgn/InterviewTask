using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //daha kolay kullanımlı bir kod çalıştırmak için result'ı iki farklı duruma (success/error) bölerek kullandım.
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {

        }

        public ErrorResult() : base(false)
        {

        }
    }
}
