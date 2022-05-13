using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Bussiness.Abstract;
using YazılımYapımıProje.DataAccess.Abstract;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.Bussiness.Concrete
{
   public class WQuestionManager:IWQuestionService
    {
        private IWQuestionDal _wquestionDal;
        public WQuestionManager(IWQuestionDal wquestionDal)
        {
            _wquestionDal = wquestionDal;
        }

        public void Add(WQuestions wQuestions)
        {
            _wquestionDal.Add(wQuestions);
        }

        public void Delete(int WQuestionId)
        {
            _wquestionDal.Delete(WQuestionId);
        }

        public List<WQuestions> GetAll()
        {
            return _wquestionDal.GetAll();
        }
    }
}
