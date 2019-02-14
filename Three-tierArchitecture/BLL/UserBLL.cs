using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class UserBLL
    {
        UserDB db = new UserDB();
        public bool addUser(User user)
        {
            return db.User_add(user);
        }
    }
}
