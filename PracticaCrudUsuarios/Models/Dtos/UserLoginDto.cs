using System.ComponentModel.DataAnnotations;

namespace PracticaCrudUsuarios.Models.Dtos{
	public class UserLoginDto{
		[Required(ErrorMessage ="El usuario es obligatorio")]
		public string Username { get; set; }
		[Required(ErrorMessage ="El password es obligatorio")]
		public string Password { get; set; }
	}
}
