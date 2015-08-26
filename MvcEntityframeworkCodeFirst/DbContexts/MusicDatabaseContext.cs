using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using MvcEntityframeworkAndProfiling.Models;

namespace MvcEntityframeworkAndProfiling.DbContexts
{
    public class MusicDatabaseContext : DbContext
    {
        public MusicDatabaseContext()
        {
            Database.Log = s => Debug.WriteLine(s);
        }
        public DbSet<Album> Albums { get; set; }

        //public DbSet<Artist> Artists { get; set; }
    }
}