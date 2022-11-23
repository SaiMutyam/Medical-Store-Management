using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Model
{
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]    //Key Generation


        public int Medicine_ID { get; set; }
        public string Medicine_Name { get; set; }             // I was trying to insert MEdicine id here but it was not executing in sql
        public string Category_Name { get; set; }
        public string Company_Name { get; set; }
        public int Quantity { get; set; }
        public string MF_Date { get; set; }
        public string EXP_Date { get; set; }
        public int Price_Rs { get; set; }
        public string Category_Of_Medicine { get; set; }
    }
}
