using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TypeEntity, TypeContext> : IEntityRepository<TypeEntity>
        where TypeEntity : class, IEntity, new()
        where TypeContext : DbContext, new()
    {
        public void Add(TypeEntity entity)
        {
            using (TypeContext context = new TypeContext()) // iş bitince bellekten atacak
            {
                var addedEntity = context.Entry(entity); //referansı yakalama
                addedEntity.State = EntityState.Added; //ekleme
                context.SaveChanges(); //degişiklikleri kaydetme
            }
        }

        public void Delete(TypeEntity entity)
        {
            using (TypeContext context = new TypeContext()) // iş bitince bellekten atacak
            {
                var deletedEntity = context.Entry(entity); //referansı yakalama
                deletedEntity.State = EntityState.Deleted; //silme
                context.SaveChanges(); //degişiklikleri kaydetme
            }
        }

        public TypeEntity Get(Expression<Func<TypeEntity, bool>> filter) // tek bir kayıt getirir
        {
            using (TypeContext context = new TypeContext())
            {
                return context.Set<TypeEntity>().SingleOrDefault(filter);
            }
        }

        public List<TypeEntity> GetAll(Expression<Func<TypeEntity, bool>> filter = null) // bütün kayıtları getirir
        {
            using (TypeContext context = new TypeContext())
            {
                // select * from products
                return filter == null ? context.Set<TypeEntity>().ToList() : context.Set<TypeEntity>().Where(filter).ToList();
            }
        }

        public void Update(TypeEntity entity)
        {
            using (TypeContext context = new TypeContext()) // iş bitince bellekten atacak
            {
                var updatedEntity = context.Entry(entity); //referansı yakalama
                updatedEntity.State = EntityState.Modified; //güncelleme
                context.SaveChanges(); //degişiklikleri kaydetme
            }
        }

    }
}
