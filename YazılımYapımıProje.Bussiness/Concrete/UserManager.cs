using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımYapımıProje.Bussiness.Abstract;
using YazılımYapımıProje.DataAccess.Abstract;
using YazılımYapımıProje.DataAccess.Concrete;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.Bussiness.Concrete
{
   public class UserManager:IUserService
    {
        /*There is just bussiness code.In this way, the Data layer and the user are separated from each other.*/
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(Users users)
        {
            _userDal.Add(users);
        }

        
        public void Delete(Users users)
        {
            _userDal.Delete(users);
        }

        public void Delete(int UserId)
        {
            _userDal.Delete(UserId);
        }

        public void SendEmail(string SendEmail)
        {
            _userDal.SendEmail(SendEmail);
        }

        public List<Users> StudentGetAll()
        {               
            return _userDal.StudentGetAll();
        }
        public List<Users> TeacherGetAll()
        {               
            return _userDal.TeacherGetAll();
        }
        public void Update(Users users)
        {
            _userDal.Update(users);
        }
        public List<Users> GetUserInformation(int UserId)
        {
            return _userDal.GetUserInformation(UserId);
        }
    }
}
