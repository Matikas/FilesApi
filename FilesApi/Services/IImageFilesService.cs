using FilesApi.Models;

namespace FilesApi.Services
{
    public interface IImageFilesService
    {
        ImageFile GetImageFile(int id);
        int AddImageFile(ImageFile imageFile);
    }
}
