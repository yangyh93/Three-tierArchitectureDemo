using Model;
using System;
using System.Data.SqlClient;
namespace DAL
{
    public class UserDB
    {
        private string strConStr = "server=.;database=User;" + "uid=sa;" + "pwd=bhkjsql2012"; //连接数据库字符串，使用SQLserver数据库
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">User类型</param>
        /// <returns>bool类型</returns>
        public bool User_add(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConStr))
                {
                    conn.Open();

                    #region 查询时候有相同id的用户
                    SqlCommand cmd2 = conn.CreateCommand();
                    cmd2.CommandText = "select * from UTable where id=" + user.ID;
                    SqlDataReader dr = cmd2.ExecuteReader();
                    #endregion
                    if (dr == null)
                    {
                        #region   增删改方法一 

                        SqlCommand cmd = new SqlCommand("insert into dbo.[UTable] ([id],[name]) values(@id,@name)", conn);
                        cmd.Parameters.AddWithValue("id", user.ID);
                        cmd.Parameters.AddWithValue("name", user.Name);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }

                    #endregion

                    #region   增删改方法二
                    /*
                    SqlCommand cmd2 = conn.CreateCommand();
                    cmd2.CommandText = "insert into UTable values("+user.ID+","+user.Name+")";
                    if (cmd2.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    */
                    #endregion
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
