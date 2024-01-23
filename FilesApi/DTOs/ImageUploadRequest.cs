using FilesApi.Attributes;

namespace FilesApi.DTOs
{
    public class ImageUploadRequest
    {
        [MaxFileSize(5 * 1024 * 1024)]  // 5 MB
        [AllowedExtensions(new[] { ".jpg", ".png" })]
        public IFormFile Image { get; set; }
    }
}
