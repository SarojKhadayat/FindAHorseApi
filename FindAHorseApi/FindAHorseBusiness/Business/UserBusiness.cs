using FindAHorseApiModel;
using FindAHorseApiModel.ApiModel;
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
        private readonly UserRepository _userRepository=new UserRepository();
       
        public int CreateUser(UserApiModel userApi)
        {
            tblUser user = new tblUser {
                FullName = userApi.FullName,
                Address = userApi.Address,
                Email = userApi.Email,
                Password=userApi.Password,
                PhoneNumber=userApi.PhoneNumber,
                ProfilePicture=userApi.ProfilePicture              
            };
          return  _userRepository.CreateUser(user,userApi.UserTypeId);
        }

        public List<tblUser> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public bool UserLogin(string userName, string password)
        {
            return _userRepository.UserLogin(userName, password);
        }
    }
}
