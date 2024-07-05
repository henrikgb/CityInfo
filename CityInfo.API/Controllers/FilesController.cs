using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

        public FilesController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider ?? throw new ArgumentNullException(nameof(fileExtensionContentTypeProvider));       
        }
        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {
            // Look up the actual file, depending on the fileId..
            // demp code
            var pathToFile = "Web Development - The big picture.pdf";
            
            // Check whether the file exist
            if(!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }

            if(!_fileExtensionContentTypeProvider.TryGetContentType(
                pathToFile, out var contentType)) 
            {
                contentType = "application/octet-stream";
            }

            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes, contentType, Path.GetFileName(pathToFile));
        }

        [HttpPost]
        public async Task<ActionResult> CreateFile(IFormFile file)
        {
            // Validate the input. Put a limit on filesize to avoid large uploads attacks. 
            // Only accept .pdf files (check content type)
            if(file.Length == 0 || file.Length > 20971520)
            {
                return BadRequest("No file or an invalid one has been inputted.");
            }

            // Following line of code is bad practice, and only okay for demo purposes...
            // Create the file path. Avoid using file.FileName, as an attacker can provide a malicious one, including full paths or relative paths. 
            var path = Path.Combine(Directory.GetCurrentDirectory(), $"uploaded_file_{Guid.NewGuid()}.pdf");

            // Store the file
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok("Your file has been uploaded successfully.");
        }
        
    }
}
