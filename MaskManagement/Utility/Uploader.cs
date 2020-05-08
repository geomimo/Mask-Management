using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Utility
{
    public static class Uploader
    {
        public static string UploadImage(IFormFile file, string toFolder)
        {
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string filePath = Path.Combine(toFolder, uniqueFileName);
            file.CopyTo(new FileStream(filePath, FileMode.Create));
            return Path.Combine("img", uniqueFileName);
        }
    }
}
