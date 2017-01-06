using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aspnet_filemanager.Models
{
    public class File
    {
        public int Id { get; set; }

        public int IdFolder { get; set; }

        public int IdType { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Path { get; set; }

        [DisplayName("Date Updated")]
        public DateTime DtUpdate { get; set; }

        public virtual Folder Folder { get; set; }

        public virtual Type Type { get; set; }
    }
}