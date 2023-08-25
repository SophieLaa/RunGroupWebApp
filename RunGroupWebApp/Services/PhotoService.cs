using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;
using RunGroupWebApp.Helpers;
using RunGroupWebApp.Interfaces;

namespace RunGroupWebApp.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly Cloudinary _cloudinary;
        public PhotoService(IOptions<CloudinarySettings> config)
        {
            var acc = new Account(
                config.Value.CloudName,
                config.Value.ApiKey,
                config.Value.ApiSecret
                );
            _cloudinary = new Cloudinary(acc);
        }
        public Task<ImageUploadResult> AddPhotoAsync(IFormFile file)
        {
            var uploadResult = new ImageUploadResult();
            if (file.Length > 0)
            {

            }
        }

        public Task<DeletionResult> DeletePhotoAsync(string publicId)
        {
            throw new NotImplementedException();
        }
    }
}
