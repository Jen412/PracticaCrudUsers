using System.ComponentModel.DataAnnotations;

namespace PracticaCrudUsuarios.Models.Dtos{
	public class UserRegisterDto{
		[Required(ErrorMessage = "El nombre es obligatorio")]
		public string Name { get; set; }
		[Required(ErrorMessage = "El apellido es obligatorio")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "El usuario es obligatorio")]
		public string Username { get; set; }
		[Required(ErrorMessage = "El password es obligatorio")]
		public string Password { get; set; }
		public int PhoneNumber { get; set; }
		public string ImagePath { get; set; }
		public enum Roles { Admin, User }
		public Roles Role { get; set; }
	}
}
