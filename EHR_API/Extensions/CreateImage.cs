using static System.Net.Mime.MediaTypeNames;

namespace EHR_API.Extensions
{
    public static class CreateImage 
    {
        public static string CreateFiles(IWebHostEnvironment _webHost, IFormFile file, string folderName) 
        {
            string fileName = Guid.NewGuid().ToString();
            var uploads = Path.Combine(_webHost.WebRootPath, $@"images\{folderName}");
            var extension = Path.GetExtension(file.FileName);

            using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
            {
                file.CopyTo(fileStreams);
            }

            var path = $@"\images\{folderName}\" + fileName + extension;
            return path;
        }
    }
}
