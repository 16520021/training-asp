using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using DAL.Dto.File;
using DAL.Models.Context;
using DAL.Models;

namespace BUS.Services
{
    public class FileServices : BaseServiceContext, IFileService
    {
        public FileServices(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        #region PUBLIC METHOD
        public void CreateOrEditFile(FileDto fileinput)
        {
            if (fileinput.id == 0)
            {
                Create(fileinput);
            } else
            {
                Update(fileinput);
            }
        }

        public void DeleteFile(int id)
        {
            var fileEntity = _context.Files.Where(x => !x.isDeleted).SingleOrDefault(x => x.id == id);
            if (fileEntity != null)
            {
                fileEntity.isDeleted = true;
                _context.SaveChanges();
            }
        }

        public FileDto GetFileForEdit(int id)
        {
            var file = _context.Files.AsNoTracking().Where(x => !x.isDeleted).SingleOrDefault(x => x.id == id);
            FileDto result = _mapper.Map<FileDto>(file);
            return result;

        }

        public List<FileDto> GetFiles(FileFilter input)
        {
            var query = _context.Files.AsNoTracking().Where(x => !x.isDeleted);
            if (input != null)
            {
                if (input.fileName != null)
                {
                    query = query.Where(x => x.fileName == input.fileName);
                }

                if (input.extension != null)
                {
                    query = query.Where(x => x.extension == input.extension);
                }

                query = query.Where(x => x.parent == input.parent);
            }

            var listOfFile = query.OrderBy(x => x.fileName).ToList();
            return listOfFile.Select(item => _mapper.Map<FileDto>(item)).ToList();
            
        }
        #endregion

        #region PRIVATE METHOD
        private void Create(FileDto file)
        {
            var fileEntity = _mapper.Map<File>(file);
            if (file.parent != 0)
                fileEntity.folder = _context.Folders.Where(x => x.id == file.parent).SingleOrDefault();
            _context.Files.Add(fileEntity);
            _context.SaveChanges();
        }

        private void Update(FileDto file)
        {
            var fileEntity = _context.Files.Where(x => !x.isDeleted).SingleOrDefault(x => x.id == file.id);
            if (fileEntity != null)
            {
                _mapper.Map<FileDto,File>(file, fileEntity);
                _context.SaveChanges();
            }
        }
        #endregion
    }
}
