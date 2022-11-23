using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Model
{
    public class DAL
    {
        DbConnect con;
        public DAL(DbConnect con)
        {
            this.con = con;
        }

        public List<Medicine> display()
        {
            List<Medicine> ls = con.Medicines.ToList();
            return ls;
        }

        public Medicine Search(int Medicine_ID)
        {
            Medicine obj = con.Medicines.Find(Medicine_ID);  // This portion is not working
            return obj;                                        // Search by med name works
        }

        public void Register(Medicine obj)
        {
            con.Medicines.Add(obj);
            con.SaveChanges();
        }
        public void Update( Medicine obj)
        {
            Medicine obj1 = con.Medicines.Find(obj.Medicine_ID);

            obj1.Medicine_ID = obj.Medicine_ID;
            obj1.Medicine_Name = obj.Medicine_Name;
            obj1.Category_Name = obj.Category_Name;
            obj1.Company_Name = obj.Company_Name;
            obj1.Quantity = obj.Quantity;
            obj1.MF_Date = obj.MF_Date;
            obj1.EXP_Date = obj.EXP_Date;
            obj1.Price_Rs = obj.Price_Rs;
            obj1.Category_Of_Medicine = obj.Category_Of_Medicine;
            con.SaveChanges();
        }

        public void Delete(int Medicine_ID)
        {
            Medicine obj1 = con.Medicines.Find(Medicine_ID);
            con.Medicines.Remove(obj1);
            con.SaveChanges();
        }


    }

}