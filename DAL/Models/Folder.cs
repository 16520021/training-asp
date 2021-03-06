using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Folder: FullAuditModel
    {
        public string folderName { get; set; }
        public int? parentID { get; set; }
        [ForeignKey("parentID")]
        public virtual List<Folder> subFolders { get; set; }
    }
}
