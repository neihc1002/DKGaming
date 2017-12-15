using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class UserDao
    {
        DKGamingDBContext db = new DKGamingDBContext();
        public int checkLogin(string username, string pass)
        {
            var result = db.Users.FirstOrDefault(u => u.UserName == username);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.isActive == false)
                {
                    return -1;
                }
                else
                {
                    if (result.Password != pass)
                    {
                        return -2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
        public Users GetUser(string username)
        {
            Users u = null;
            var user = db.Users.Find(username);
            if (user != null)
            {
                u = user;
            }
            return u;
        }
    }
}
