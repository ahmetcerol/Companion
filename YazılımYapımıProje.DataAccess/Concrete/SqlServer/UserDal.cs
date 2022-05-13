using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımYapımıProje.DataAccess.Abstract;
using YazılımYapımıProje.Entities.Concrete;
using System.Net;
using System.Net.Mail;

namespace YazılımYapımıProje.DataAccess.Concrete
{
    public class UserDal: IUserDal
    {
       
        SqlConnection aconnection = new SqlConnection
           (@"server=(localdb)\mssqllocaldb; initial catalog=CompanionData; integrated security=true");
        private void ConnectionControl()
        {
            if (aconnection.State == ConnectionState.Closed)
            {
                aconnection.Open();
            }
        }
        public List<Users> StudentGetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select UserId,UserName,UserSurname,UserEMail from UserTable Where UserType='Student'", aconnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Users> user = new List<Users>();
            while (reader.Read())
            {
                Users users = new Users()
                {
                    UserId = Convert.ToInt32(reader["UserId"]),
                    UserEMail = reader["UserEMail"].ToString(),
                    UserName = reader["UserName"].ToString(),
                    UserSurname = reader["UserSurname"].ToString(),

                };
                user.Add(users);

            }
            reader.Close();
            aconnection.Close();

            return user;
        }
        
        public void Logging(string name, string password,bool doğrulama) {
            try
            {
                ConnectionControl();
                string sql = "Select * From UserTable where UserType='Teacher'AND UserEMail=@adi AND UserPassword=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", name);
                SqlParameter prm2 = new SqlParameter("sifresi", password);
                SqlCommand komut = new SqlCommand(sql, aconnection);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    doğrulama = true;
                }
            }
            catch (Exception)
            {
                doğrulama = false;
              
            }
          
           
         

        }

            
        public List<Users> TeacherGetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select UserId,UserName,UserSurname,UserEMail from UserTable Where UserType='Teacher'", aconnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Users> user = new List<Users>();
            while (reader.Read())
            {
                Users users = new Users()
                {
                    UserId = Convert.ToInt32(reader["UserId"]),
                    UserEMail = reader["UserEMail"].ToString(),
                    UserName = reader["UserName"].ToString(),
                    UserSurname = reader["UserSurname"].ToString(),

                };
                user.Add(users);

            }
            reader.Close();
            aconnection.Close();

            return user;
        }
        public void Add(Users users)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into UserTable values(@UserName,@UserSurname,@UserEMail,@UserPassword,@UserType)", aconnection);
            command.Parameters.AddWithValue("@UserName", users.UserName);
            command.Parameters.AddWithValue("@UserSurname", users.UserSurname);
            command.Parameters.AddWithValue("@UserEMail", users.UserEMail);
            command.Parameters.AddWithValue("@UserPassword", users.UserPassword);
            command.Parameters.AddWithValue("@UserType", users.UserType);
            command.ExecuteNonQuery();
            aconnection.Close();
        }
        public void Update(Users users)
        {
            //Settings yetişirse yazılacak
        }
        public void Delete(int UserId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from UserTable Where UserId=@UserId", aconnection);
            command.Parameters.AddWithValue("@UserId", UserId);
            command.ExecuteNonQuery();
            aconnection.Close();
        }

        public void SendEmail(string UserEMail)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From UserTable Where UserEMail=@UserEMail",aconnection);
            command.Parameters.AddWithValue("@UserEMail",UserEMail);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {               
                    SmtpClient smtpServer = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String Date = DateTime.Now.ToLongDateString();
                    String OurMail =("companion687@gmail.com");
                    String Password = "202803033";
                    String smptserver = "smtp.gmail.com";
                    String EmailAdress = (reader["UserEMail"].ToString());
                    String MailTopic = ("Password Reminder Mail");
                    String MailMessage = ("Dear," + reader["UserName"].ToString() + "\n" + reader["UserSurname"].ToString() + "\n" + "Your request ın" + Date + "\ndated password reminder email" + "\n" + "Your Password\n" + reader["UserPassword"].ToString() + "\n Have a nice day");
                    smtpServer.Credentials = new NetworkCredential(OurMail, Password);
                    smtpServer.Port =587;
                    smtpServer.Host = smptserver;
                    mail.IsBodyHtml = true;
                    smtpServer.EnableSsl = true;
                    mail.From = new MailAddress(OurMail);
                    mail.To.Add(EmailAdress);
                    mail.Subject = MailTopic;
                    mail.Body = MailMessage;
                    smtpServer.Send(mail);                            
            }
            reader.Close();
            aconnection.Close();
        }

        public List<Users> GetAll() { 
            throw new NotImplementedException();
        }

        public void Delete(Users sql)
        {
            throw new NotImplementedException();
        }

        
    }
}
