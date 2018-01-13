using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data.BaseModels;
using LostAndFound.Framework.Enums;

namespace LostAndFound.Data.Models.Content
{
    public class File : BaseModel
    {
        public Guid FileGuid { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public FileType FileType { get; set; }
     
    }
}
