using Microsoft.AspNetCore.Mvc;

namespace codePuls.API.Models.DTO
{
    public class ImageUploadRequestDto
    {
        public IFormFile file { get; set; }

        public string fileName { get; set; }

        public string title { get; set; }
    }
}


///public async Task<IActionResult> UploadImage([FromForm] IFormFile file,
//        //    [FromForm] string fileName, [FromForm] string title)