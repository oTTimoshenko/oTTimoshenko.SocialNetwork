using oTTimoshenko.SocialNetwork.ApplicationLogic.UsersManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oTTimoshenko.SocialNetwork.ApplicationLogic.Interfaces
{
    public interface IUserService
    {
        bool LogIn(LogInDTO dto);
        void Registrate(RegistrateDTO dto);
        void LogOut();
    }
}
