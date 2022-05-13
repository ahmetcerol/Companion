using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.Bussiness.Abstract
{
    public interface IWQuestionService
    {
        List<WQuestions> GetAll();
        void Delete(int WQuestionId);
        void Add(WQuestions wQuestions);
    }
}
