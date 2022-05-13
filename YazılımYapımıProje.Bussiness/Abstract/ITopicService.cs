using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.Bussiness.Abstract
{
   public interface ITopicService
    {
        List<Topic> GetAll();
    }
}
