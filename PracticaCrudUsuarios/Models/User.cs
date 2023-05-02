using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PracticaCrudUsuarios.Models{
	public class User{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public int PhoneNumber { get; set; }
		public string ImagePath { get; set; }
		public enum Roles { Admin, User }
		public Roles Role { get; set; }
	}
}
