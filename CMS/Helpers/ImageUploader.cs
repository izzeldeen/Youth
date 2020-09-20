using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Helpers
{
    public class ImageUploader
    {
        public string Upload(IFormFile image, string path, int userId)
        {
            var folderName = Path.Combine("Documents", path);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            string extension = Path.GetExtension(image.FileName);

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            string nameToUse = path;
            nameToUse = nameToUse.Replace(" ", String.Empty);

            var uniqueFileName = $"{nameToUse}_admin_{userId}{extension}";
            var dbPath = Path.Combine(folderName, uniqueFileName);

            using (var fileStream = new FileStream(Path.Combine(filePath, uniqueFileName), FileMode.Create))
            {
                image.CopyTo(fileStream);
            }

            var Url = $"{dbPath}";

            return "http://dashboard.alamanahdairy.com/" + Url;

        }

        public string Upload(IFormFile image, string path)
        {
            var folderName = Path.Combine("Documents", path);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            string extension = Path.GetExtension(image.FileName);

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            string nameToUse = path + DateTime.Now.Ticks.ToString();
            nameToUse = nameToUse.Replace(" ", String.Empty);

            var uniqueFileName = $"{nameToUse}_admin_{image.Name}{extension}";
            var dbPath = Path.Combine(folderName, uniqueFileName);

            using (var fileStream = new FileStream(Path.Combine(filePath, uniqueFileName), FileMode.Create))
            {
                image.CopyTo(fileStream);
            }

            var Url = $"{dbPath}";

            return "http://dashboard.alamanahdairy.com/" + Url;

        }
    }
}
