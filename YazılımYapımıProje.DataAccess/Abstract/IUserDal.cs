using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.DataAccess.Abstract
{
    public interface IUserDal:ISqlRepository<Users>
    {  
        List<Users> StudentGetAll();
        List<Users> TeacherGetAll();
        void Delete(int UserId);
        void SendEmail(string UserEMail);
        
    }
}
