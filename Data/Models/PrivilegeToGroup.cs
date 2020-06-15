using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class PrivilegeToGroup
    {
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }

        public Guid PrivilegeId { get; set; }
        public Privilege Privilege { get; set; }

    }
}
