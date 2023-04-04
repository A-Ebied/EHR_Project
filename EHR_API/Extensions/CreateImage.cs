namespace EHR_API.Extensions
{
    public static class CreateImage 
    {
        public static string CreateFiles(IWebHostEnvironment _webHost, IFormFile image, string folderName) 
        {
            var extension = Path.GetExtension(image.FileName);

            string fileName = Guid.NewGuid().ToString();
            var uploads = Path.Combine(_webHost.WebRootPath, $@"images\{folderName}");

            using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
            {
                image.CopyTo(fileStreams);
            }

            var path =  "/" + folderName + "/" + fileName + extension;
            return path;
        }
    }
}
