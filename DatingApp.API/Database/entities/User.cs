using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.database.entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string  Username { get; set; }

        
        [Required]
        [StringLength(255)]
        public string  Email { get; set; }


        
        public byte[] passwordSalt { get; set; }
   
        public byte[] passwordHash { get; set; }
    }
}