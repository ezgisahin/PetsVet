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
        [Display(Name="Tür")]
        public string Kind { get; set; }
        [Display(Name="Cins")]
        public string Species { get; set; }
        [Display(Name="Ad")]
        public string Name { get; set; }
        [Display(Name="Yaş")]
        public int Age { get; set; }
        [StringLength(200)]
        [Display(Name="Hastalık")]
        public string illness { get; set; }
        [Display(Name="Açıklama")]
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        [StringLength(200)]
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        [StringLength(200)]
        public string UpdatedBy { get; set; }

        [Display(Name = "Sahibi")]
        public int? OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        [Display(Name="Sahibi")]
        public Owner Owner { get; set; }
    }
}
