using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISupplierService
    {
        IDataResult<List<Supplier>> GetAll();
        IResult Add(Supplier supplier);
        IResult Delete(Supplier supplier);
        IResult Update(Supplier supplier);
    }
}
