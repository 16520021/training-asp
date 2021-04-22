using DAL.Models;

namespace DAL.Dto.Folder
{
    public class FolderDto: FullAuditModel
    {
        public string folderName { get; set; }
        public int? parentID { get; set; }
    }
}
