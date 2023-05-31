namespace EHR_API.Extensions
{
    public static class CreateImage 
    {
        public static string CreateFiles(IWebHostEnvironment _webHost, IFormFile image, string folderName) 
        {
            var extension = Path.GetExtension(image.FileName);

            string fileName = image.FileName;
            var uploads = Path.Combine(_webHost.WebRootPath, $@"files\{folderName}");

            using (var fileStreams = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
            {
                image.CopyTo(fileStreams);
            }

            var path = "/files/" + folderName + "/" + fileName;
            return path;
        }
    }
}
