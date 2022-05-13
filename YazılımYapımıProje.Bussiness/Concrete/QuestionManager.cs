using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Bussiness.Abstract;
using YazılımYapımıProje.DataAccess.Abstract;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.Bussiness.Concrete
{
    public class QuestionManager : IQuestionService
    {
        private IQuestionDal _questionDal;
        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public void Add(Questions questions)
        {
            _questionDal.Add(questions);
        }

        public List<Questions> Exam()
        {
             return _questionDal.Exam();
        }
        public void Delete(int QuestionId)
        {
            _questionDal.Delete(QuestionId);
        }

        public List<Questions> GetAll()
        {
            return _questionDal.GetAll();
        }
    }
}
