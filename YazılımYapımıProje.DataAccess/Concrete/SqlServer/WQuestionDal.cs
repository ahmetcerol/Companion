using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using YazılımYapımıProje.DataAccess.Abstract;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.DataAccess.Concrete.SqlServer
{
   public class WQuestionDal:IWQuestionDal
    {
        SqlConnection cconnection = new SqlConnection
          (@"server=(localdb)\mssqllocaldb; initial catalog=CompanionData; integrated security=true");
        private void ConnectionControl()
        {
            if (cconnection.State == ConnectionState.Closed)
            {
                cconnection.Open();
            }
        }
        public List<WQuestions> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from WaitingQuestion W INNER JOIN QuestionTopic T ON W.QuestionTopicId=T.QuestionTopicId ", cconnection);
            SqlDataReader reader = command.ExecuteReader();
            List<WQuestions> wquestion = new List<WQuestions>();
            while (reader.Read())
            {
                WQuestions wquestions = new WQuestions()
                {
                    WQuestionId = Convert.ToInt32(reader["WQuestionId"]),
                    WQuestionText = reader["WQuestionText"].ToString(),
                    WQuestionAnswerA = reader["WQuestionAnswerA"].ToString(),
                    WQuestionAnswerB = reader["WQuestionAnswerB"].ToString(),
                    WQuestionAnswerC = reader["WQuestionAnswerC"].ToString(),
                    WQuestionAnswerD = reader["WQuestionAnswerD"].ToString(),
                    WQuestionTopicId=Convert.ToInt32(reader["QuestionTopicId"]),
                    WQuestionTopicName=reader["QuestionTopicName"].ToString(),
                    WQuestionCorrectAnswer=reader["WQuestionCorrectAnswer"].ToString(),

                };
                wquestion.Add(wquestions);

            }
            reader.Close();
            cconnection.Close();
            return wquestion;
        }
        public void Add(WQuestions wquestions)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into WaitingQuestion values(@WQuestionText,@WQuestionAnswerA,@WQuestionAnswerB,@WQuestionAnswerC,@WQuestionAnswerD,@QuestionTopicId,@WQuestionCorrectAnswer)", cconnection);

            command.Parameters.AddWithValue("@WQuestionText", wquestions.WQuestionText);
            command.Parameters.AddWithValue("@WQuestionAnswerA", wquestions.WQuestionAnswerA);
            command.Parameters.AddWithValue("@WQuestionAnswerB", wquestions.WQuestionAnswerB);
            command.Parameters.AddWithValue("@WQuestionAnswerC", wquestions.WQuestionAnswerC);
            command.Parameters.AddWithValue("@WQuestionAnswerD", wquestions.WQuestionAnswerD);
            command.Parameters.AddWithValue("@WQuestionCorrectAnswer", wquestions.WQuestionCorrectAnswer);
            command.Parameters.AddWithValue("@QuestionTopicId", wquestions.WQuestionTopicId);
            command.ExecuteNonQuery();
            cconnection.Close();
        }
        public void Update(WQuestions wquestions)
        {
            //Settings yetişirse yazılacak
        }
        public void Delete(WQuestions wquestions)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from WaitingQuestion", cconnection);
            command.ExecuteNonQuery();
            cconnection.Close();
        }

        public void Delete(int WQuestionId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from WaitingQuestion Where WQuestionId=@WQuestionId", cconnection);
            command.Parameters.AddWithValue("@WQuestionId", WQuestionId);
            command.ExecuteNonQuery();
            cconnection.Close();
        }
    }
}
