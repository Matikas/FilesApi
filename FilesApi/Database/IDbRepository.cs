using FilesApi.Models;

namespace FilesApi.Database
{
    public interface IDbRepository
    {
        ImageFile GetImageFile(int id);
        int AddImageFile(ImageFile imageFile);
        void DeleteImageFile(int id);
    }
}
