using FilesApi.Models;

namespace FilesApi.Database
{
    public class DbRepository : IDbRepository
    {
        private readonly FilesDbContext _context;

        public DbRepository(FilesDbContext context)
        {
            _context = context;
        }

        public int AddImageFile(ImageFile imageFile)
        {
            _context.ImageFiles.Add(imageFile);
            _context.SaveChanges();
            return imageFile.Id;
        }

        public void DeleteImageFile(int id)
        {
            var imageFile = _context.ImageFiles.Find(id);
            if (imageFile != null)
            {
                _context.ImageFiles.Remove(imageFile);
                _context.SaveChanges();
            }
        }

        public ImageFile GetImageFile(int id)
        {
            return _context.ImageFiles.Find(id);
        }
    }
}
