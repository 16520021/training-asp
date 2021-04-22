using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class FullAuditModel
    {
        [Key]
        public int id { get; set; }
        public string owner { get; set; }
        public string createAt { get; set; }
        public string modifiedAt { get; set; }
        public string modifiedBy { get; set; }
        public bool isDeleted { get; set; }
    }
}
