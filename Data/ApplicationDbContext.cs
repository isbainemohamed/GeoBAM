using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeoBAM.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Constructeur de la classe
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Déclaration des tables avec lesquelles , la connexion sera établie
        public DbSet<User> Users { get; set; }
        
        public DbSet<GeometricPoint> AddedPoints { get; set; }
        public DbSet<GeoJSONData> AddedData { get; set; }
    }
}


 
