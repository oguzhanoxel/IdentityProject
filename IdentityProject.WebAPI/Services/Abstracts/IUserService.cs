using Azure;
using IdentityProject.WebAPI.Models;
using IdentityProject.WebAPI.Models.Dtos.Users.Request;
using IdentityProject.WebAPI.Models.Dtos.Users.Response;
using System.Linq.Expressions;

namespace IdentityProject.WebAPI.Services.Abstracts;

public interface IUserService
{
	UserResponseDto Create(CreateUserRequestDto dto);
	UserResponseDto Update(UpdateUserRequestDto dto);
	UserResponseDto Delete(DeleteUserRequestDto dto);
	UserResponseDto Get(Expression<Func<User, bool>> predicate);
	List<UserResponseDto> GetAll(Expression<Func<User, bool>> predicate = null);
}
