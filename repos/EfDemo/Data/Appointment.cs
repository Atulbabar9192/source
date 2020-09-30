using System;
using System.Collections.Generic;
using System.Text;

namespace EfDemo.Data
{
    public class Appointment
    {
        public int id { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        public int DoctorID { get; set; }
        public  Doctor Doctor { get; set; }
        public DateTime AppointDate { get; set; }
        public string Status { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Prescription { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
