using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Model
{
    public class userl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string User_Name { get; set; }
        public string Email { get; set; }
        public string Phone_No { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }
    }
}
