using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfShipperDal : EfEntityRepositoryBase<Shipper, NorthwindContext>, IShipperDal
    {

    }

}
