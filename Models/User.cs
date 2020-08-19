using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EONRealityFinal.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [BindProperty]
        public string Gender { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DateRegistered { get; set; }

        [Required]
        public string EventDays { get; set; }

        [StringLength(100)]
        public string Request { get; set; }
    }
}
