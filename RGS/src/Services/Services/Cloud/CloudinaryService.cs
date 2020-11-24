using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Core.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Cloud
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly IOptions<CloudinarySettings> _cloudinaryConfig;
        private Cloudinary _cloudinary;
        public CloudinaryService(IOptions<CloudinarySettings> cloudinaryConfig)
        {
            _cloudinaryConfig = cloudinaryConfig;
            Account account = new Account(
                _cloudinaryConfig.Value.CloudName,
                _cloudinaryConfig.Value.ApiKey,
                _cloudinaryConfig.Value.ApiSecret
            );
            _cloudinary = new Cloudinary(account);
        }
        public async Task<string> AddPhotoForUser(IFormFile file)
        {
            try
            {
                var uploadResult = new ImageUploadResult();
                if (file.Length > 0)
                {
                    using (var stream = file.OpenReadStream())
                    {
                        var uploadParams = new ImageUploadParams()
                        {
                            File = new FileDescription(file.Name, stream)
                            //Transformation = new Transformation()
                            //.Width(500).Height(500)
                            //.Crop("fill")
                            //.Gravity("face")
                        };
                        uploadResult = await _cloudinary.UploadAsync(uploadParams);
                    }
                }
                //photoDto.PublicId = uploadResult.PublicId;
                return uploadResult.Uri.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
