using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Model
{
    public class dall
    {
        DbConnect con;
        public dall(DbConnect con)
        {
            this.con = con;
        }

        public List<userl> display()
        {
            List<userl> ls = con.userls.ToList();
            return ls;
        }

        public userl Search(int UserId)
        {
            userl obj = con.userls.Find(UserId);
            return obj;
        }

        public void Register(userl obj)
        {
            con.userls.Add(obj);
            con.SaveChanges();
        }

    }
}
    

