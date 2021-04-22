using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Dto.File
{
    public class FileFilter
    {
        public string fileName { get; set; }
        public string extension { get; set; }
        public int parent { get; set; }
    }
}
