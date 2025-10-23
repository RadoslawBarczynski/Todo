using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;
using TodoApi.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TodoApi.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Todo> Todos { get; set; }

    }
}