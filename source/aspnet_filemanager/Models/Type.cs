using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aspnet_filemanager.Models
{
    public class Type
    {
        public Type()
        {
            File = new HashSet<File>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("Extension")]
        public string Extension { get; set; }

        [Required]
        [StringLength(200)]
        [DisplayName("Image Path")]
        public string ImagePath { get; set; }

        [DisplayName("Date Updated")]
        public DateTime DtUpdate { get; set; }
        
        public virtual ICollection<File> File { get; set; }
    }
}