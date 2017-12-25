using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetsVet.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }

        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Doctor { get; set; }
        public string Departmant { get; set; }
    }
}
