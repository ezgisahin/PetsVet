using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetsVet.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Display(Name="Sahibin Adı")]
        public string FirstName { get; set; }
        [Display(Name="Sahibin Soyadı")]
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
        [StringLength(200)]
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        [StringLength(200)]
        public string UpdatedBy { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
