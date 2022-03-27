using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Tüm entityler için; DA katmanında oluşturduğum, o entity'e ait methodları içeren interfacelerde
    //ortak olan işlemleri tek bir interface'e atayıp hepsi için burayı referans veriyorum ki hepsi için tekrar tekrar yazmak zorunda kalmayayım sadece değişkeni değiştirerek implemente edebileyim
    
    //Generic bir yapıda oluşturduğum IEntityRepository<T> interface'inin değişkeni T'yi sınırlandırdım, öyle ki;
    //T, IEntity referansına sahip, implemente edilmiş bir class olmalı, 
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //datanın belli bir kısmını getirmek için verilmesi gerekecek olan filtreyi (verilmeyebilir de)
        //LINQ yapısıyla GetAll komutuna ekliyorum.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
