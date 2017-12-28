using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetsVet.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Display(Name = "İsim")]
        [StringLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Telefon alanı gereklidir")]
        [StringLength(200)]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "E-posta alanı gereklidir")]
        [StringLength(200)]
        [Display(Name = "E-posta")]
        public string Email { get; set; }

        [Display(Name = "Randevu Tarihi")]
        public DateTime AppointmentDate { get; set; }

        [Display(Name = "Doktor")]
        public string Doctor { get; set; }

        [Display(Name = "İşlem")]
        public string Departmant { get; set; }

        [Display(Name = "Randevu")]
        public int? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        [Display(Name = "Randevu")]
        public Doctor Doctors { get; set; }
    }
}
