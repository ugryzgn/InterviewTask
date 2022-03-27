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
    public class CategoryManager : ICategoryService
    {
        //İş kodlarının veri erişim yöntemine bağımlı olmaması için
        //constructor yapısıyla, kullanılan Dal'ı injection yaptım. Artık manager veriye soyut bir referans üzerinden erişecek.

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            //ekleme işlemine bir koşul koyan iş kodu 
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategorySuccessAdded);
        }

        public IResult Delete(Category category)
        {
            return new SuccessResult(Messages.CategorySuccessDeleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            //saat 22 olduğunda sistemin kapanmasını simüle etmeyi sağlayacak iş kodu
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Category>>(Messages.CategoryErrorGetAll);
            }
            return new SuccessDataResult<List<Category>> (_categoryDal.GetAll(),Messages.CategorySuccessGetAll);
        }

        public IResult Update(Category category)
        {
            return new SuccessResult(Messages.CategorySuccessUpdated);
        }
    }
}
