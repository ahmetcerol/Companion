using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Entities.Abstract;

namespace YazılımYapımıProje.Entities.Concrete
{
    public class Topic:IEntity
    {
        public int QuestionTopicId { get; set; }
        public string QuestionTopicName { get; set; }

    }
}
