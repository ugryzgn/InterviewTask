using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public IResult Add(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Supplier>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
