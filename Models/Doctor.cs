using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int doctorID { set; get; }
        public int doctorFullName { set; get; }
        public string doctorPhysicalAddress { set; get; }
        public string doctorPhoneNumber { set; get; }
        public string qualification { set; get; }
        public string gender { set; get; }
        public virtual ICollection<Appointment> Appointment { get; set; }
}

}
