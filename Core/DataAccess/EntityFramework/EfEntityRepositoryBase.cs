using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    //Dal'da her bir entity için implementasyon yaparken değişecek olan parametreler sadece entity ve context türü
    //olacağı için ilgili metodları hepsinde tekrar tekrar yazmamak adına bir base class oluşturup bu class'a da
    //Dal'da entitylerin referanslarını tutan interface'ten metodları implemente ederek ve sonrasında bu class'ı
    //her bir entityDal'da inherit ederek kullanacağım.

    //Yazdığım repository iki parametreye ihtiyaç duyacak ve ortak methodların hepsini içerecek.
    //Bu yapı doğru şekilde kullanılabilsin diye daha önce yaptığım gibi yine burada da parametreleri sınırlandırıyorum.
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
