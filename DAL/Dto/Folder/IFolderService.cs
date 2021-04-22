using System.Collections.Generic;

namespace DAL.Dto.Folder
{
    public interface IFolderService
    {
        void CreateOrEditFolder(FolderDto fold);
        FolderDto GetFolderForEdit(int id);
        void DeleteFolder(int id);
        List<FolderDto> GetFolders(FolderFilter input);
    }
}
