using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Cloud
{
    public interface ICloudinaryService
    {
        Task<string> AddPhotoForUser(IFormFile file);
    }
}
