using FilesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilesApi.Database
{
    public class FilesDbContext : DbContext
    {
        public DbSet<ImageFile> ImageFiles { get; set; }

        public FilesDbContext(DbContextOptions<FilesDbContext> options) : base(options)
        {
        }
    }
}
