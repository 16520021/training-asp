using System.Collections.Generic;

namespace DAL.Dto.File
{
    public interface IFileService
    {
        void CreateOrEditFile(FileDto fileinput);
        FileDto GetFileForEdit(int id);
        void DeleteFile(int id);
        List<FileDto> GetFiles(FileFilter input);
    }
}
