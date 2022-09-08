using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.database.entities
{
    [Table("Song")]
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string  Name { get; set; } = String.Empty;
        public string  Singer { get; set; } = String.Empty;
        public string Author { get; set; } = String.Empty;
        public bool favorite {get; set;}
        public double Price { get; set; }

        public List<Playlist> Playlists { get; set; }

        public RemarkablePoint RemarkablePoint { get; set; }
        public int RemarkablePointId {get; set;}

       

    
    }
}