using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.database.entities
{
    [Table("RemarkablePoint")]
    public class RemarkablePoint
    {
        [Key]
        public int Id { get; set; }

        public string Symbol { get; set; }
        public double Star { get; set; }

        public Song Song {get; set;}


    
    }
}