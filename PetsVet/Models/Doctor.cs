using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetsVet.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Display(Name = "Doktor Adı")]
        public string Name { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
