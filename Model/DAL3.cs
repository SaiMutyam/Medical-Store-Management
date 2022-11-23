using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Model
{
    public class DAL3
    {
        DbConnect con;
        public DAL3(DbConnect con)
        {
            this.con = con;
        }

        public List<Admin> display()
        {
            List<Admin> ls = con.admins.ToList();
            return ls;
        }

        public Admin Search(int empno)
        {
            Admin obj = con.admins.Find(empno);
            return obj;
        }

        public void Register(Admin obj)
        {
            con.admins.Add(obj);
            con.SaveChanges();
        }

        public void Update(Admin obj)
        {
            Admin obj1 = con.admins.Find(obj.admin_id);
            obj1.admin_id = obj.admin_id;
            obj1.admin_name = obj.admin_name;
            obj1.admin_username = obj.admin_username;
            obj1.admin_password = obj.admin_password;
            obj1.securityQ1 = obj.securityQ1;
            con.SaveChanges();
        }

        public void Delete(int admin_id)
        {
            Admin obj1 = con.admins.Find(admin_id);
            con.admins.Remove(obj1);
            con.SaveChanges();
        }
    }
}
