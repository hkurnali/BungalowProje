using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
  public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= DESKTOP-JEPLJDD\\SQLEXPRESS; database= BungalowDb; integrated security=true");
        }
        public DbSet<Team> Staffs { get; set;}
        public DbSet<AboutUs> AboutUs { get; set;}
        public DbSet<IndexSlider> IndexSliders { get; set;}
        public DbSet<IndexVideo> IndexVideos { get; set;}
        public DbSet<Room> Rooms { get; set;}
        public DbSet<Service> Services { get; set;}
        public DbSet<Team> Teams { get; set;}

    }
}
