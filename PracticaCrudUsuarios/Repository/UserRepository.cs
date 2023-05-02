using PracticaCrudUsuarios.Models;
using PracticaCrudUsuarios.Models.Dtos;
using PracticaCrudUsuarios.Repository.IRepository;
using XSystem.Security.Cryptography;

namespace PracticaCrudUsuarios.Repository{
	public class UserRepository : IUserRepository{
		public Task<User> AddUser(UserRegisterDto userRegisterDto){
			var passwordEncrypted = getMD5(userRegisterDto.Password);
		}

		public bool DeleteUser(User user){
			throw new NotImplementedException();
		}

		public User GetUser(int userId){
			throw new NotImplementedException();
		}

		public ICollection<User> GetUsers(){
			throw new NotImplementedException();
		}

		public void Home(){
			throw new NotImplementedException();
		}

		public bool IsUniqueUser(string user){
			throw new NotImplementedException();
		}

		public Task<UserLoginRepsonseDto> Login(UserLoginDto userLoginDto){
			throw new NotImplementedException();
		}

		public bool UpdateUser(User user){
			throw new NotImplementedException();
		}
		public static string getMD5(string password){
			MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
			byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
			data = x.ComputeHash(data);
			string resp = "";
			for (int i = 0; i < data.Length; i++)
			{
				resp += data[i].ToString("x2").ToLower();
			}
			return resp;
		}
	}
}
