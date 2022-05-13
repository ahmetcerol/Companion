using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.Bussiness.Abstract
{
    public interface IUserService
    {
        List<Users> StudentGetAll();
        List<Users> TeacherGetAll();
        void Delete(int UserId);

        void Add(Users users);
        void SendEmail(string UserEMail);
 
       
    }
}
