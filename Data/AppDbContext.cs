using DotNetCrudWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<PollInstance> PollInstances { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=localhost;Username=alexmalder;Password=alexmalder;Database=alexmalder");
    }
}