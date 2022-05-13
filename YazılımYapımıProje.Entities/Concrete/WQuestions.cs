using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Entities.Abstract;

namespace YazılımYapımıProje.Entities.Concrete
{
    public class WQuestions:IEntity
    {   public int WQuestionId { get; set; }
        public string WQuestionText { get; set; }
        public string WQuestionAnswerA { get; set; }
        public string WQuestionAnswerB { get; set; }
        public string WQuestionAnswerC { get; set; }
        public string WQuestionAnswerD { get; set; }
        public string WQuestionTopicName { get; set; }
        public int WQuestionTopicId { get; set; }
        public string WQuestionCorrectAnswer { get; set; }
    }
}
