using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class UserToGroup
    {
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
