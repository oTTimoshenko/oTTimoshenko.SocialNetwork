using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oTTimoshenko.SocialNetwork.Domain.UsersEntities
{
    public class UserProfile: BaseEntity
    {
        //public int UserProfileID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public User User { get; set; }
    }
}
