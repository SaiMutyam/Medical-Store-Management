using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Model
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int admin_id { get; set; }
        public string admin_name { get; set; }
        public string admin_username { get; set; }
        public string admin_password { get; set; }
        public string securityQ1 { get; set; }

    }
}
