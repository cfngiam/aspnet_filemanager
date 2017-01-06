using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aspnet_filemanager.Models
{
    public class Folder
    {
        public Folder()
        {
            File = new HashSet<File>();
        }

        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdParentFolder { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Date Created")]
        public DateTime DtCreate { get; set; }

        [DisplayName("Date Updated")]
        public DateTime DtUpdate { get; set; }
        
        public virtual ICollection<File> File { get; set; }

        public virtual User User { get; set; }
    }
}