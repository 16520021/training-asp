using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class File: FullAuditModel
    {
        public string fileName { get; set; }
        public string extension { get; set; }
        [ForeignKey("parent")]
        public int parent { get; set; }
        public Folder folder { get; set; }
    }
}
