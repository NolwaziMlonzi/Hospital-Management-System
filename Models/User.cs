using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userID { set; get; }
        public string userName { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string role { set; get; }
        public string password { set; get; }
    }
}
