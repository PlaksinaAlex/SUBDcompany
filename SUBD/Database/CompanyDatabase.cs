using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Database.Tables;

namespace Database
{
	public class CompanyDatabase : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<ProjectNumber> ProjectNumbers { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<Staff> Staffs { get; set; }

       // private readonly StreamWriter _logStream = new StreamWriter("../../../../mylog.txt", append: true);
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.LogTo(_logStream.WriteLine, LogLevel.Information);

            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=local;Username=postgres;Password=qwer");
        }
        public override void Dispose()
        {
            base.Dispose();
            //_logStream.Dispose();
        }
    }
}
