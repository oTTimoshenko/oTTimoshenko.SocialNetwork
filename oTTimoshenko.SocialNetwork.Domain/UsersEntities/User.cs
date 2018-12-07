using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oTTimoshenko.SocialNetwork.Domain.UsersEntities
{
    public class User: BaseEntity
    {
        //public int UserID { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public bool IsOnline { get; set; }

        public UserAccountState AccountState { get; set; }

        public DateTime RegistrationDateTime { get; set; }

        public UserProfile Profile { get; set; }
    }
}
