using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public class AnotherAuthRepo : IAuthRepository
    {
        Task<User> IAuthRepository.Login(string username, string password)
        {
            throw new System.NotImplementedException("Another Repository");
        }

        Task<User> IAuthRepository.Register(User user, string password)
        {
            throw new System.NotImplementedException("Another Repository");
        }

        Task<bool> IAuthRepository.UserExists(string username)
        {
            throw new System.NotImplementedException("Another Repository");
        }
    }
}