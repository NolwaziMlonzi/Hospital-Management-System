using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int patientID { set; get; }
        public string patientFullName { set; get; }
        public int patientAge { set; get; }
        public string patientGender { set; get; }
        public string patientPhysicalAddress { set; get; }
        public string date { set; get; }
        public string patientContactNumber { set; get; }
        public string patientRoomNumber { set; get; }
    }
}
