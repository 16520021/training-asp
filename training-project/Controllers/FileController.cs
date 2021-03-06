using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using DAL.Dto.File;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DAL.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileService fileService;

        public FileController(IFileService fileService)
        {
            this.fileService = fileService;
        }
        // GET: api/<FileController>
        [HttpGet]
        public IEnumerable<FileDto> GetFiles([FromQuery] FileFilter input)
        {
            var result = fileService.GetFiles(input);
            return result;
        }

        // GET api/<FileController>/5
        [HttpGet("{id}")]
        public FileDto GetFileById(int id)
        {
            return fileService.GetFileForEdit(id);
        }

        [HttpPut]
        public void CreateOrEditFile(FileDto fileinput)
        {
            fileinput.modifiedBy = User.Identity.Name;
            fileService.CreateOrEditFile(fileinput);
        }

        // DELETE api/<FileController>/5
        [HttpDelete("{id}")]
        public void DeleteFile(int id)
        {
            fileService.DeleteFile(id);
        }
    }
}
