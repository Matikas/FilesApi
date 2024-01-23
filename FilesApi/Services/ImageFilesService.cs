using FilesApi.Database;
using FilesApi.Models;

namespace FilesApi.Services
{
    public class ImageFilesService : IImageFilesService
    {
        private readonly IDbRepository _dbRepository;

        public ImageFilesService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        public int AddImageFile(ImageFile imageFile)
        {
            return _dbRepository.AddImageFile(imageFile);
        }

        public ImageFile GetImageFile(int id)
        {
            return _dbRepository.GetImageFile(id);
        }
    }
}
