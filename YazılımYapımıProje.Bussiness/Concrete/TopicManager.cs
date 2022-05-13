using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Bussiness.Abstract;
using YazılımYapımıProje.DataAccess.Abstract;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.Bussiness.Concrete
{
    public class TopicManager : ITopicService
    {
        private ITopicDal _topicDal;
        public TopicManager(ITopicDal topicDal)
        {
            _topicDal = topicDal;
        }
     public List<Topic> GetAll()
        {
            return _topicDal.GetAll();
        }
    }
}
