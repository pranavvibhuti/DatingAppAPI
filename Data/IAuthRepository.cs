using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<users> Register(users user, string password);
         Task<users> Login(string username, string password);

         Task<bool> UserExists(string username);
    }
}