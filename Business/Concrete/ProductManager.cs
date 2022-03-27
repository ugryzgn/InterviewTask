using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //Constructor injection
        //Loose coupling
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //ekleme işlemine bir koşul koyan iş kodu 
            if (product.ProductName.Length<2)
            {
                return new ErrorResult(Messages.ProductErrorAdded);
            }

            _productDal.Add(product);
            return new SuccessResult(Messages.ProductSuccessAdded);
        }

        public IResult Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetAll()
        {
            //saat 22 olduğunda sistemin kapanmasını simüle etmeyi sağlayacak iş kodu
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Product>>(Messages.ProductErrorGetAll);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductSuccessGetAll);
        }

        public IResult Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
