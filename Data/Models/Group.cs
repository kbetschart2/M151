using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Group
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        ICollection<UserToGroup> UserToGroup { get; set; }
        ICollection<PrivilegeToGroup> PrivilegeToGroup { get; set; }
    }
}
