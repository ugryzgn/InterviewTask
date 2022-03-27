using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Liste döndüren metotlar için ayrıca bir result interface tanımlıyorum ki aynı zamanda hem mesaj hem data hem
    //durum bilgisi döndürsün. Bu interface IResult interface'indeki tüm özellikleri içermenin yanında bir de 
    //T türünde bir data da içerecek.
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
