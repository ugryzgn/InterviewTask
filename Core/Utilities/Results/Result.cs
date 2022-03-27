using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //constructor yapısıyla döndüreceğimiz result'a mesaj ve durum parametrelerini
        //farklı senaryolar için(mesaj-durum bilgisi beraber,sadece durum bilgisi)
        //konfigüre ederek ekledim. (overloading)
        //tekrar eden kod satırı yazmamak için this ile ilk constructor'ın sonucunu 
        //ikinci constructor'a göndererek beraber çalışmalarını sağladım.
        //ve bu parametreleri sadece constructor içinde set edilebilir hale getirerek
        //sadece standart mesajlar ve durumlar içerecek hale getirdim.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
