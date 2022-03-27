using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //CRUD operasyonları sadece bir veri tipi değil de içerisinde işlem durumu,mesajı içeren bir sonuç döndürsün
    //istediğimden, itediğim bu yapıyı oluşturacağım class'ın interface'i.
    //Encapsulation yapıyorum.
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
