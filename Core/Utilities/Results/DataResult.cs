using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // tıpkı resulttaki gibi farklı senaryolar için constructorları konfigüre ettim. Tek farkla;
    // DataResult bir data da içeriyor.
    // ilk constructor'ın sonucunu base class'a yönlendirdiğimiz için ikinci constructor'a yönlendiremeyiz
    //dolayısıyla burada data set işlemini iki kere yazmak zorundayım.
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success,message)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
