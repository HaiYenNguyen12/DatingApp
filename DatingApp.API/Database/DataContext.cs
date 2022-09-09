using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Database.entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<RemarkablePoint> RemarkablePoints { get; set; }
    }
}