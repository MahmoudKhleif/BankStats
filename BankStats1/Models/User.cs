using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BankStats1.Models
{
    [Table("User")]
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25)]
        public string FullName { get; set; } = null!;
        [StringLength(20)]
        public string Bank { get; set; } = null!;
    }
}
