using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace DAL
{
    public class UserDB
    {
        private string Constr = "server=.;database=User;" + "uid=sa;" + "pwd=bhkjsql2012";
        public bool User_add(User model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into dbo.[UTable] ([id],[name]) values(@id,@name)", conn);
                    cmd.Parameters.AddWithValue("id", model.ID);
                    cmd.Parameters.AddWithValue("name", model.Name);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
