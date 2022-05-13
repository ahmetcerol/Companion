using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Entities.Abstract;

namespace YazılımYapımıProje.DataAccess.Abstract
{
   public interface ISqlRepository<T> where T:class ,IEntity, new()
    {
        List<T> GetAll();
        void Add(T sql);
        void Update(T sql);
        void Delete(T sql);
    }
}
