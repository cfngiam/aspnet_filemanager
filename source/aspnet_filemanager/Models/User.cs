using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aspnet_filemanager.Models
{
    public class User
    {
        public User()
        {
            Folder = new HashSet<Folder>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Is Active?")]
        public bool IsActive { get; set; }

        [DisplayName("Date Updated")]
        public DateTime DtUpdate { get; set; }

        public string ResetPasswordHash { get; set; }

        public bool IsResetPasswordActive { get; set; }

        public string ResetPasswordCode { get; set; }

        public virtual ICollection<Folder> Folder { get; set; }
    }
}