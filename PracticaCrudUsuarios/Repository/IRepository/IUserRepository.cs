using PracticaCrudUsuarios.Models;
using PracticaCrudUsuarios.Models.Dtos;

namespace PracticaCrudUsuarios.Repository.IRepository{
	public interface IUserRepository{
		Task<User> AddUser(UserRegisterDto userRegisterDto);
		bool UpdateUser(User user);
		bool DeleteUser(User user);
		User GetUser(int userId);
		ICollection<User> GetUsers();
		bool IsUniqueUser(string user);
		Task<UserLoginRepsonseDto> Login(UserLoginDto userLoginDto);
		bool Save();
	}
}
