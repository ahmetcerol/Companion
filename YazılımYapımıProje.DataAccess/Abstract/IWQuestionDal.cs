using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.DataAccess.Abstract
{
   public interface IWQuestionDal:ISqlRepository<WQuestions>
    {
        void Delete(int WQuestionId);
    }
}
