using DAL;
using Model;
namespace BLL
{
    public class UserBLL
    {
        UserDB db = new UserDB();
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsAddUser(User user)
        {
            return db.User_add(user);
        }
    }
}
