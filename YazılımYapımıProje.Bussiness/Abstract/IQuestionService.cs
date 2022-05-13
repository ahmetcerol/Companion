using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.Bussiness.Abstract
{
   public interface IQuestionService
    {
        List<Questions> GetAll();
        void Add(Questions questions);
        List<Questions> Exam();
        void Delete(int QuestionId);
    }
}
