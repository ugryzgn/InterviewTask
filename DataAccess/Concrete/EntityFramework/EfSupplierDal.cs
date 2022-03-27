using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSupplierDal : EfEntityRepositoryBase<Supplier, NorthwindContext>, ISupplierDal
    {

    }

}
