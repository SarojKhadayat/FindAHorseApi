using FindAHorseApiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAHorseBusiness.Business
{
    public interface IUserBusiness
    {
        List<tblUser> GetAllUsers();
        bool UserLogin(string userName,string password);
        int CreateUser(tblUser user);
     }
}
