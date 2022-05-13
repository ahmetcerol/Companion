using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımYapımıProje.Entities.Abstract;

namespace YazılımYapımıProje.Entities.Concrete
{
   public class Users:IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEMail { get; set; }
        public int UserPassword { get; set; }
        public string UserType { get; set; }
        

    }
}
