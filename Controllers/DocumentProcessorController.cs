using DocumentProcessor.Models;
using DocumentProcessor.Services;
using Microsoft.AspNetCore.Mvc;

namespace DocumentProcessor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentProcessorController(DocumentProcessorService documentProcessorService) : ControllerBase
    {
        private readonly DocumentProcessorService _documentProcessorService = documentProcessorService;

        /// <summary>
        /// Upload document with specific version on the request
        /// </summary>
        /// <param name="request"></param>
        /// <returns>string that says the version of the document</returns>
        [HttpPost("upload")]
        public IActionResult UploadDocument([FromForm] DocumentProcessorRequest request)
        {
            return Ok(_documentProcessorService.Execute(request.File, request.DocumentVersion));
        }

        /// <summary>
        /// Upload document with specific to version 1
        /// </summary>
        /// <param name="file"></param>
        /// <returns>string that says the version of the document</returns>
        [HttpPost("upload/v1")]
        public IActionResult UploadDocumentVersion1(IFormFile file)
        {
            return Ok(_documentProcessorService.Execute(file, "Version1"));
        }

        /// <summary>
        /// Upload document with specific to version 2
        /// </summary>
        /// <param name="file"></param>
        /// <returns>string that says the version of the document</returns>
        [HttpPost("upload/v2")]
        public IActionResult UploadDocumentVersion2(IFormFile file)
        {
            return Ok(_documentProcessorService.Execute(file, "Version2"));
        }
    }
}
