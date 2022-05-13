using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using YazılımYapımıProje.DataAccess.Abstract;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.DataAccess.Concrete.SqlServer
{
    public class QuestionDal: IQuestionDal
    {

        SqlConnection bconnection = new SqlConnection
           (@"server=(localdb)\mssqllocaldb; initial catalog=CompanionData; integrated security=true");
        private void ConnectionControl()
        {
            if (bconnection.State == ConnectionState.Closed)
            {
                bconnection.Open();
            }
        }
        public List<Questions> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Questions Q INNER JOIN QuestionTopic T ON Q.QuestionTopicId=T.QuestionTopicId", bconnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Questions> question = new List<Questions>();
            while (reader.Read())
            {
                Questions questions = new Questions()
                {
                    QuestionId = Convert.ToInt32(reader["QuestionId"]),
                    QuestionText = reader["QuestionText"].ToString(),
                    QuestionAnswerA=reader["QuestionAnswerA"].ToString(),
                    QuestionAnswerB=reader["QuestionAnswerB"].ToString(),
                    QuestionAnswerC=reader["QuestionAnswerC"].ToString(),
                    QuestionAnswerD=reader["QuestionAnswerD"].ToString(),
                    QuestionTopicName=reader["QuestionTopicName"].ToString(),
                    QuestionCorrectAnswer=reader["QuestionCorrectAnswer"].ToString(),

                };
                question.Add(questions);

            }
            reader.Close();
            bconnection.Close();
            return question;
        }      
        public void Add(Questions questions)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Questions values(@QuestionText,@QuestionAnswerA,@QuestionAnswerC,@QuestionAnswerD,@QuestionCorrectAnswer,@QuestionTopicId,@QuestionAnswerB)", bconnection);
            command.Parameters.AddWithValue("@QuestionText",questions.QuestionText);
            command.Parameters.AddWithValue("@QuestionAnswerA",questions.QuestionAnswerA );
            command.Parameters.AddWithValue("@QuestionAnswerC",questions.QuestionAnswerC);
            command.Parameters.AddWithValue("@QuestionAnswerD",questions.QuestionAnswerD);
            command.Parameters.AddWithValue("@QuestionCorrectAnswer",questions.QuestionCorrectAnswer);
            command.Parameters.AddWithValue("@QuestionTopicId",questions.QuestionTopicId);
            command.Parameters.AddWithValue("@QuestionAnswerB", questions.QuestionAnswerB);
            command.ExecuteNonQuery();
            bconnection.Close();
        }
        public void Update(Questions questions)
        {
            //Settings yetişirse yazılacak
        }
        public void Delete(Questions questions)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Questions", bconnection);
            command.ExecuteNonQuery();
            bconnection.Close();
        }
        public List<Questions> Exam()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select TOP 1 *FROM Questions Q INNER JOIN QuestionTopic T ON Q.QuestionTopicId=T.QuestionTopicId ORDER BY NEWID()", bconnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Questions> question = new List<Questions>();
            while (reader.Read())
            {
                Questions questions = new Questions()
                {
                    QuestionId = Convert.ToInt32(reader["QuestionId"]),
                    QuestionText = reader["QuestionText"].ToString(),
                    QuestionAnswerA = reader["QuestionAnswerA"].ToString(),
                    QuestionAnswerB = reader["QuestionAnswerB"].ToString(),
                    QuestionAnswerC = reader["QuestionAnswerC"].ToString(),
                    QuestionAnswerD = reader["QuestionAnswerD"].ToString(),
                    QuestionTopicName = reader["QuestionTopicName"].ToString(),
                    QuestionCorrectAnswer = reader["QuestionCorrectAnswer"].ToString(),
                    QuestionPicture=reader["QuestionPicture"].ToString(),
                };
                question.Add(questions);
            }
            reader.Close();
            bconnection.Close();
            return question;
        }
        public void Delete(int QuestionId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Questions Where QuestionId=@QuestionId",bconnection);
            command.Parameters.AddWithValue("@QuestionId", QuestionId);
            command.ExecuteNonQuery();
            bconnection.Close();
        }
    }
}

