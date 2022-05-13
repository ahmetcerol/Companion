using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using YazılımYapımıProje.DataAccess.Abstract;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.DataAccess.Concrete
{
    public class TopicsDal:ITopicDal
    {
        SqlConnection dconnection = new SqlConnection
         (@"server=(localdb)\mssqllocaldb; initial catalog=CompanionData; integrated security=true");
        private void ConnectionControl()
        {
            if (dconnection.State == ConnectionState.Closed)
            {
                dconnection.Open();
            }
        }
        public List<Topic> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from QuestionTopic ", dconnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Topic> topic = new List<Topic>();
            while (reader.Read())
            {
                Topic topics = new Topic()
                {
                    QuestionTopicId=Convert.ToInt32(reader["QuestionTopicId"]),
                    QuestionTopicName=reader["QuestionTopicName"].ToString(),

                };
                topic.Add(topics);

            }
            reader.Close();
            dconnection.Close();
            return topic;
        }
        public void Add(Topic topics)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into QuestionTopic values(@QuestionTopicName)", dconnection);

            command.ExecuteNonQuery();
            dconnection.Close();
        }
        public void Update(Topic topics)
        {
            //Settings yetişirse yazılacak
        }
        public void Delete(Topic topics)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from QuestionTopic", dconnection);
            command.ExecuteNonQuery();
            dconnection.Close();
        }
    }
}

