using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımYapımıProje.Entities.Abstract;

namespace YazılımYapımıProje.Entities.Concrete
{
    public class Students:IEntity
    {
        public int StudentId { get; set; }
        public string StudentEMail { get; set; }
        public int StudentCorrectQuestions { get; set; }
        public DateTime CorrectQuestionsDate { get; set; }
    }
}
