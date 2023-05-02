using AutoMapper;
using PracticaCrudUsuarios.Models;
using PracticaCrudUsuarios.Models.Dtos;

namespace PracticaCrudUsuarios.UsuariosMapper{
	public class UsersMapper:Profile{
        public UsersMapper(){
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
