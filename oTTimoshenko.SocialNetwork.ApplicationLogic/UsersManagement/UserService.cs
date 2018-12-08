using oTTimoshenko.SocialNetwork.ApplicationLogic.Interfaces;
using oTTimoshenko.SocialNetwork.ApplicationLogic.UsersManagement.DTO;
using oTTimoshenko.SocialNetwork.DataAccess.EntityFramework.Repositories.Interfaces;
using oTTimoshenko.SocialNetwork.Domain.UsersEntities;
using System;
using System.Linq;

namespace oTTimoshenko.SocialNetwork.ApplicationLogic.UsersManagement
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUserProfileRepository userProfileRepository;

        public UserService(IUserRepository userRepository, IUserProfileRepository userProfileRepository)
        {
            this.userRepository = userRepository;
            this.userProfileRepository = userProfileRepository;
        }

        public bool LogIn(LogInDTO dto)
        {
            if (userRepository.GetAll().Any(u => u.Login.Equals(dto.Login)))
                if (userRepository.GetAll().Any(u => u.Login.Equals(dto.Login) && u.Password.Equals(dto.Password)))
                {
                    var user = userRepository.GetAll().FirstOrDefault(u => u.Login.Equals(dto.Login) && u.Password.Equals(dto.Password));
                    user.IsOnline = true;

                    userRepository.Save();
                    return true;
                }
                else
                    throw new Exception("Wrong password");
            else
                throw new Exception("User with that e-mail not exists");
        }

        public void LogOut()
        {
            throw new System.NotImplementedException();
        }

        public void Registrate(RegistrateDTO dto)
        {
            User user = RegistrateUserAccount(dto);
            RegistrateUserProfile(dto, user);
        }

        private User RegistrateUserAccount(RegistrateDTO dto)
        {
            if (IsUserAlreadyExists(dto.Email))
                throw new Exception("User with that e-mail already exists");

            if (!dto.Password.Equals(dto.ConfirmPassword))
                throw new Exception("Passwords are not equals");

            var user = new User()
            {
                Login = dto.Email,
                Password = dto.Password,
                RegistrationDateTime = DateTime.Now,
                AccountState = UserAccountState.Active,
                IsOnline = false
            };

            userRepository.Add(user);

            return user;
        }

        private UserProfile RegistrateUserProfile(RegistrateDTO dto, User user)
        {
            if (IsUserAlreadyExists(dto.Email))
                throw new Exception("User with that e-mail already exists");

            if (IsUserAlreadyExists(dto.PhoneNumber))
                throw new Exception("User with that phone number already exists");

            var userProfile = new UserProfile()
            {
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                City = dto.City,
                Country = dto.Country,
                Name = dto.Name,
                Surname = dto.Surname,
                User = user
            };

            userProfileRepository.Add(userProfile);
            userProfileRepository.Save();

            return userProfile;
        }

        public bool IsUserAlreadyExists(string EmailOrPhone) =>
            userProfileRepository.GetAll().Any(u => u.PhoneNumber.Equals(EmailOrPhone) || u.Email.Equals(EmailOrPhone));
    }
}
