using FindAHorseApiModel;
using FindAHorseApiModel.ApiModel;
using FindAHorseRepository.Common;
using FindAHorseRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAHorseBusiness.Business
{
    public class UserBusiness
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public int CreateUser(UserApiModel userApi)
        {
            tblUser user = new tblUser
            {
                FullName = userApi.FullName,
                TownOrCity = userApi.TownOrCity,
                Country = userApi.Country,
                PostCode = userApi.PostCode,
                Email = userApi.Email,
                Password = userApi.Password,
                PhoneNumber = userApi.PhoneNumber,
                UserType = (int)Enum.Parse(typeof(UserTypeEnum), userApi.UserType, true),
                ProfilePicture = userApi.ProfilePicture
            };
            return _userRepository.CreateUser(user);
        }

        public List<tblUser> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public tblUser UserLogin(string userName, string password, int userType)
        {
            return _userRepository.UserLogin(userName, password, userType);
        }
        public bool CheckIfUserExist(string email, int userType)
        {
            return _userRepository.CheckIfUserExist(email, userType);
        }
    }
}
