using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mulakat.Web.Helpers
{
    public class MulakatWebHelper
    {
        private IHostingEnvironment hostingEnvironment;

        public MulakatWebHelper(IHostingEnvironment hostingEnvironment)
        {

            hostingEnvironment = hostingEnvironment;
        }

        public async Task<string> SaveImage(IFormFile formFile)
        {
            string fileName;
            var uniqueName = Guid.NewGuid();
            var fileArray = formFile.FileName.Split('.');
            string extension = fileArray[fileArray.Length - 1].ToLower();
            fileName = uniqueName + "." + extension;
            if (extension == "jpg" || extension == "png" || extension == "gif" || extension == "jpeg")
            {
                string filePath = Path.Combine(hostingEnvironment.WebRootPath, "Uploads", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }
            return fileName;
        }
    }
}
