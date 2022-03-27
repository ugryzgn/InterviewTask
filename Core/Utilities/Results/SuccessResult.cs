using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //daha kolay kullanımlı bir kod çalıştırmak için result'ı iki farklı (success/error) duruma bölerek kullandım.
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {

        }

        public SuccessResult() : base(true)
        {

        }

    }
}
