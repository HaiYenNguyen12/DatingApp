using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Database.entities
{
    [Table("Playlist")]
    public class Playlist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string  Name { get; set; }

        public string Status {get; set;}
         public string Description { get; set; }
         public int UserId { get; set; }
         public User User { get; set; }
         public virtual ICollection<Song> Songs { get; set; }
    }
}