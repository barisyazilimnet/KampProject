using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{                                               
                                              //Type verilecek olan degeri kısıtladık Type:class diyerek referans tip girilmesini istedik ve Ya IEntity nin içeridigi bir class olmalı ve new'lenebilir olmalı
    public interface IEntityRepository<Type> where Type:class,IEntity,new()
    {
        List<Type> GetAll(Expression<Func<Type,bool>> filter=null);
        Type Get(Expression<Func<Type, bool>> filter);
        void Add(Type entity);
        void Update(Type entity);
        void Delete(Type entity);
    }
}
