using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.DataAccess.Abstract
{
    public interface IQuestionDal : ISqlRepository<Questions>
    {
        List<Questions> Exam();
        void Delete(int QuestionId);
    }
}
