namespace VibePhone.Services
{
    public class UploadImages
    {
        private readonly IWebHostEnvironment _HostEnvironment;

        public UploadImages(IWebHostEnvironment webHostEnvironment)
        {
            _HostEnvironment = webHostEnvironment;
        }
       
        //  ====================================================================
        //                                UploadImage
        //    ====================================================================
        public string UploadImage(IFormFile formFile, string folderName = "UploadImages")
        {
            string folderPath = Path.Combine(_HostEnvironment.WebRootPath, folderName);
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            // Safe file name
            string fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(formFile.FileName);
            string filePath = Path.Combine(folderPath, fileName);

            // Save file
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                formFile.CopyTo(stream);
            }

            return fileName;
        }

        //  ====================================================================
        //                                DeleteImage
        //    ====================================================================
        public string DeleteImage(string fileName, string folderName = "UploadImages")
        {
            if (string.IsNullOrEmpty(fileName))return null;

            string folderPath = Path.Combine(_HostEnvironment.WebRootPath, folderName);
            string filePath = Path.Combine(folderPath, Path.GetFileName(fileName));

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return filePath;
        }




    }
}
