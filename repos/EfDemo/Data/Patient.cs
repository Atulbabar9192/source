using System;
using System.Collections.Generic;
using System.Text;

namespace EfDemo.Data
{
    public class Patient

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LirstName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public IList<Patient> Patients{ get; set;}
        public IList<Doctor> Doctors { get; set; }
    }
 }
