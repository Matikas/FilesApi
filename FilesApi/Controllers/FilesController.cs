using FilesApi.DTOs;
using FilesApi.Models;
using FilesApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IImageFilesService _imageFilesService;
        public FilesController(IImageFilesService imageFilesService)
        {
            _imageFilesService = imageFilesService;
        }

        [HttpPost("upload")]
        public IActionResult Upload([FromForm] ImageUploadRequest request)
        {
            using var memoryStream = new MemoryStream();
            request.Image.CopyTo(memoryStream);
            var imageBytes = memoryStream.ToArray();
            var imageFile = new ImageFile
            {
                Content = imageBytes,
                ContentType = request.Image.ContentType,
                FileName = request.Image.FileName,
                Size = imageBytes.Length
            };

            return Ok(_imageFilesService.AddImageFile(imageFile));
        }

        [HttpGet("download/{id}")]
        public IActionResult Download(int id)
        {
            var imageFile = _imageFilesService.GetImageFile(id);
            if (imageFile == null)
            {
                return NotFound();
            }

            return File(imageFile.Content, imageFile.ContentType, imageFile.FileName);
        }
    }
}
