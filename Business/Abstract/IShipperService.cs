using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IShipperService
    {
        IDataResult<List<Shipper>> GetAll();
        IResult Add(Shipper shipper);
        IResult Delete(Shipper shipper);
        IResult Update(Shipper shipper);
    }
}
