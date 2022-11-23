/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Model
{
    public class DAL2
    {
        DbConnect con;
        public DAL2(DbConnect con)
        {
            this.con = con;
        }

        public List<User> display()
        {
            List<User> ls = con.users.ToList();
            return ls;
        }

        public User Search(int UserId)
        {
            User obj = con.users.Find(UserId);
            return obj;
        }

        public void Register(User obj)
        {
            con.users.Add(obj);
            con.SaveChanges();
        }

    }
}
*/