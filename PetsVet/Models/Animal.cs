using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetsVet.Models
{
    public class Animal
    {
        public int Id { get; set; }
        [Display(Name="Hayvanlar")]
        public string Name { get; set; }
        public int Age { get; set; }
        [StringLength(200)]
        public string illness { get; set; }
        public string Description { get; set; }
        [StringLength(200)]
        public string Photo { get; set; }
        public DateTime CreateDate { get; set; }
        [StringLength(200)]
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        [StringLength(200)]
        public string UpdatedBy { get; set; }

        public int? OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public Owner Owner { get; set; }
    }
}
