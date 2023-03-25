namespace EHR_API.Extensions
{
    public static class CreateImage 
    {
        public static string CreateFiles(IWebHostEnvironment _webHost, /*byte[] image,*/ IFormFile image, /*string imageName ,*/string folderName) 
        {
            var extension = Path.GetExtension(image.FileName);

            //var stream = new MemoryStream(image);
            //IFormFile file = new FormFile(stream, 0, stream.Length, imageName, extension);

            string fileName = Guid.NewGuid().ToString();
            var uploads = Path.Combine(_webHost.WebRootPath, $@"images\{folderName}");

            using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
            {
                //file.CopyTo(fileStreams);
                image.CopyTo(fileStreams);
            }

            var path =  "/" + folderName + "/" + fileName + extension;
            return path;
        }
    }
}
