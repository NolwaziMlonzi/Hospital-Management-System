using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int appointmentID { set; get; }
        public int patientID { set; get; }
        public int date { set; get; }
        [ForeignKey("Doctor")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int doctorID
        {
            get;
            set;
        }
        public virtual ICollection<Doctor> Doctor { get; set; }

}
}
