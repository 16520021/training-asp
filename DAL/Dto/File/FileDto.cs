using DAL.Models;

namespace DAL.Dto.File
{
    public class FileDto : FullAuditModel
    {
        public string extension { get; set; }
        public string fileName { get; set; }
        public int parent { get; set; }
    }
}
