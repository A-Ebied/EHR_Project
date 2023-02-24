using static System.Net.Mime.MediaTypeNames;

namespace EHR_API.Extensions
{
    public static class CreateImage 
    {
        public static string CreateFiles(IWebHostEnvironment _webHost, byte[] userImage, string imageName ,string folderName) 
        {
            var extension = Path.GetExtension(imageName);

            var stream = new MemoryStream(userImage);
            IFormFile file = new FormFile(stream, 0, stream.Length, imageName, extension);

            string fileName = Guid.NewGuid().ToString();
            var uploads = Path.Combine(_webHost.WebRootPath, $@"images\{folderName}");

            using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
            {
                file.CopyTo(fileStreams);
            }

            var path = uploads + "\\" + fileName + extension;
            return path;
        }
    }
}
