using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımYapımıProje.Entities.Abstract;

namespace YazılımYapımıProje.Entities.Concrete
{
    public class Questions:IEntity
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionAnswerA { get; set; }
        public string QuestionAnswerB { get; set; }
        public string QuestionAnswerC { get; set; }
        public string QuestionAnswerD { get; set; }
        public string QuestionTopicName { get; set; }
        public string QuestionCorrectAnswer { get; set; }
        public int QuestionTopicId { get; set; }
        public string QuestionPicture { get; set; }
    }
}
